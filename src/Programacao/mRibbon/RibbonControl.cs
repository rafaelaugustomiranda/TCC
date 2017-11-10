using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mRibbon
{
    public class RibbonControl : TabControl
    {
        #region Global Ribbon Operations
        public static ColorScheme ColorScheme = ColorScheme.Custom;
        public static Color Color = SystemColors.Control;
        public static Color TextColor = SystemColors.ControlText;

        public static Color HSL2RGB(double hue, double saturation, double luminance)
        {
            double r = 0.0, g = 0.0, b = 0.0;

            if (luminance == 0.0)
                r = g = b = 0.0;
            else if (saturation == 0.0)
                r = g = b = luminance;
            else
            {
                double aux2 = ((luminance <= 0.5) ? luminance * (1.0 + saturation) : luminance + saturation - (luminance * saturation));
                double aux1 = 2.0 * luminance - aux2;

                double[] t3 = new double[] { hue + 1.0 / 3.0, hue, hue - 1.0 / 3.0 };
                double[] clr = new double[] { 0.0, 0.0, 0.0 };

                for (int i = 0; i < 3; i++)
                {
                    if (t3[i] < 0)
                        t3[i] += 1.0;
                    if (t3[i] > 1)
                        t3[i] -= 1.0;

                    if (6.0 * t3[i] < 1.0)
                        clr[i] = aux1 + (aux2 - aux1) * t3[i] * 6.0;
                    else if (2.0 * t3[i] < 1.0)
                        clr[i] = aux2;
                    else if (3.0 * t3[i] < 2.0)
                        clr[i] = (aux1 + (aux2 - aux1) * ((2.0 / 3.0) - t3[i]) * 6.0);
                    else
                        clr[i] = aux1;
                }

                r = clr[0];
                g = clr[1];
                b = clr[2];
            }

            if (r > 1.0)
                r = 1.0;
            if (g > 1.0)
                g = 1.0;
            if (b > 1.0)
                b = 1.0;

            return Color.FromArgb((int)(255.0 * r), (int)(255.0 * g), (int)(255.0 * b));
        }

        public static Color GetColor(double luminance)
        {
            Color col = RibbonControl.HSL2RGB(RibbonControl.Color.GetHue() / 360.0, RibbonControl.Color.GetSaturation() / 2.0, RibbonControl.Color.GetBrightness() * 1.025);

            double r = (double)col.R * luminance;
            double g = (double)col.G * luminance;
            double b = (double)col.B * luminance;

            if (r > 255.0)
                r = 255.0;
            if (g > 255.0)
                g = 255.0;
            if (b > 255.0)
                b = 255.0;

            return Color.FromArgb((int)r, (int)g, (int)b);
        }

        public static void DrawRoundRectangle(Graphics g, Pen pen, Rectangle rectangle, float radius)
        {
            float size = radius * 2f;

            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90);
            gp.AddArc(rectangle.X + rectangle.Width - size, rectangle.Y, size, size, 270, 90);
            gp.AddArc(rectangle.X + rectangle.Width - size, rectangle.Y + rectangle.Height - size, size, size, 0, 90);
            gp.AddArc(rectangle.X, rectangle.Y + rectangle.Height - size, size, size, 90, 90);
            gp.CloseFigure();
            g.DrawPath(pen, gp);
            gp.Dispose();
        }
        public static void FillRoundRectangle(Graphics g, Brush brush, Rectangle rectangle, float radius)
        {
            float size = radius * 2f;

            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90);
            gp.AddArc(rectangle.X + rectangle.Width - size, rectangle.Y, size, size, 270, 90);
            gp.AddArc(rectangle.X + rectangle.Width - size, rectangle.Y + rectangle.Height - size, size, size, 0, 90);
            gp.AddArc(rectangle.X, rectangle.Y + rectangle.Height - size, size, size, 90, 90);
            gp.CloseFigure();
            g.FillPath(brush, gp);
            gp.Dispose();
        }
        public static void DrawTopRoundRectangle(Graphics g, Pen pen, Rectangle rectangle, float radius)
        {
            float size = radius * 2f;

            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90);
            gp.AddArc(rectangle.X + rectangle.Width - size, rectangle.Y, size, size, 270, 90);
            gp.AddLine(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height, rectangle.X, rectangle.Y + rectangle.Height);
            gp.CloseFigure();
            g.DrawPath(pen, gp);
            gp.Dispose();
        }
        public static void FillTopRoundRectangle(Graphics g, Brush brush, Rectangle rectangle, float radius)
        {
            float size = radius * 2f;

            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90);
            gp.AddArc(rectangle.X + rectangle.Width - size, rectangle.Y, size, size, 270, 90);
            gp.AddLine(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height, rectangle.X, rectangle.Y + rectangle.Height);
            gp.CloseFigure();
            g.FillPath(brush, gp);
            gp.Dispose();
        }

        public static void RenderSelection(Graphics g, Rectangle rectangle, float radius, bool pressed)
        {
            if (pressed)
            {
                Color[] col = new Color[] { Color.FromArgb(254, 216, 170), Color.FromArgb(251, 181, 101), Color.FromArgb(250, 157, 52), Color.FromArgb(253, 238, 170) };
                float[] pos = new float[] { 0.0f, 0.4f, 0.4f, 1.0f };

                ColorBlend blend = new ColorBlend();
                blend.Colors = col;
                blend.Positions = pos;
                LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                brush.InterpolationColors = blend;

                FillRoundRectangle(g, brush, rectangle, 2f);

                DrawRoundRectangle(g, new Pen(Color.FromArgb(171, 161, 140)), rectangle, radius);
                rectangle.Offset(1, 1);
                rectangle.Width -= 2;
                rectangle.Height -= 2;
                DrawRoundRectangle(g, new Pen(new LinearGradientBrush(rectangle, Color.FromArgb(223, 183, 136), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rectangle, radius);
            }
            else
            {
                Color[] col = new Color[] { Color.FromArgb(255, 254, 227), Color.FromArgb(255, 231, 151), Color.FromArgb(255, 215, 80), Color.FromArgb(255, 231, 150) };
                float[] pos = new float[] { 0.0f, 0.4f, 0.4f, 1.0f };

                ColorBlend blend = new ColorBlend();
                blend.Colors = col;
                blend.Positions = pos;
                LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                brush.InterpolationColors = blend;

                FillRoundRectangle(g, brush, rectangle, 2f);

                DrawRoundRectangle(g, new Pen(Color.FromArgb(210, 192, 141)), rectangle, radius);
                rectangle.Offset(1, 1);
                rectangle.Width -= 2;
                rectangle.Height -= 2;
                DrawRoundRectangle(g, new Pen(new LinearGradientBrush(rectangle, Color.FromArgb(255, 255, 247), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rectangle, 2f);
            }
        }
        public static void RenderTopSelection(Graphics g, Rectangle rectangle, float radius, bool pressed)
        {
            if (pressed)
            {
                Color[] col = new Color[] { Color.FromArgb(254, 216, 170), Color.FromArgb(251, 181, 101), Color.FromArgb(250, 157, 52), Color.FromArgb(253, 238, 170) };
                float[] pos = new float[] { 0.0f, 0.4f, 0.4f, 1.0f };

                ColorBlend blend = new ColorBlend();
                blend.Colors = col;
                blend.Positions = pos;
                LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                brush.InterpolationColors = blend;

                FillTopRoundRectangle(g, brush, rectangle, 2f);

                DrawTopRoundRectangle(g, new Pen(Color.FromArgb(171, 161, 140)), rectangle, radius);
                rectangle.Offset(1, 1);
                rectangle.Width -= 2;
                rectangle.Height -= 2;
                DrawTopRoundRectangle(g, new Pen(new LinearGradientBrush(rectangle, Color.FromArgb(223, 183, 136), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rectangle, radius);
            }
            else
            {
                Color[] col = new Color[] { Color.FromArgb(255, 254, 227), Color.FromArgb(255, 231, 151), Color.FromArgb(255, 215, 80), Color.FromArgb(255, 231, 150) };
                float[] pos = new float[] { 0.0f, 0.4f, 0.4f, 1.0f };

                ColorBlend blend = new ColorBlend();
                blend.Colors = col;
                blend.Positions = pos;
                LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                brush.InterpolationColors = blend;

                FillTopRoundRectangle(g, brush, rectangle, 2f);

                DrawTopRoundRectangle(g, new Pen(Color.FromArgb(210, 192, 141)), rectangle, radius);
                rectangle.Offset(1, 1);
                rectangle.Width -= 2;
                rectangle.Height -= 2;
                DrawTopRoundRectangle(g, new Pen(new LinearGradientBrush(rectangle, Color.FromArgb(255, 255, 247), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rectangle, 2f);
            }
        }
        #endregion

        public event RibbonPopupEventHandler OnPopup;

        private int hoverindex;
        private bool pressed;
        private int height;

        public RibbonControl()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.Size = new Size(116, 116);
            this.height = 116;
            this.Dock = DockStyle.Top;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.SelectedIndex = 1;
            this.hoverindex = -1;
        }

        protected override void OnSelecting(TabControlCancelEventArgs e)
        {
            base.OnSelecting(e);

            if (e.TabPageIndex == 0)
            {
                e.Cancel = true;

                if (OnPopup != null)
                    OnPopup(this);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (!this.GetTabRect(0).Contains(e.X, e.Y) && this.Height == 26)
                this.Size = new Size(this.Width, this.height);
        }
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            if (!this.GetTabRect(0).Contains(e.X, e.Y))
            {
                this.height = this.Height;
                this.Size = new Size(this.Width, 26);
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            for (int i = 0; i < this.TabCount; i++)
            {
                if (this.GetTabRect(i).Contains(e.X, e.Y))
                {
                    this.hoverindex = i;

                    break;
                }
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            this.pressed = true;
            this.Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            this.pressed = false;
            this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.hoverindex = -1;

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            switch (RibbonControl.ColorScheme)
            {
                case ColorScheme.Blue:
                    {
                        e.Graphics.Clear(Color.FromArgb(191, 219, 255));

                        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                        if (this.Height > 26)
                        {
                            RibbonControl.FillRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(5, this.Height - 20, this.Width - 10, 17), 3f);
                            RibbonControl.FillRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(5, this.Height - 20, this.Width - 10, 16), 3f);
                        }

                        int ti = 0;
                        foreach (TabPage tab in this.TabPages)
                        {
                            Rectangle tabrect = this.GetTabRect(ti);
                            tabrect.Height += 4;

                            if (this.SelectedIndex > 0 && this.Height > 26 && tab == this.SelectedTab)
                            {
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(tabrect.X - 2, tabrect.Y, tabrect.Width + 4, tabrect.Height + 4), 3f);
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(16, Color.Black)), new Rectangle(tabrect.X - 1, tabrect.Y, tabrect.Width + 2, tabrect.Height + 4), 3f);
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new LinearGradientBrush(tabrect, Color.FromArgb(235, 243, 254), Color.FromArgb(220, 231, 245), LinearGradientMode.Vertical), tabrect, 3f);

                                RibbonControl.DrawTopRoundRectangle(e.Graphics, new Pen(Color.FromArgb(141, 178, 227)), tabrect, 3f);
                                tabrect.Offset(1, 1);
                                tabrect.Width -= 2;
                                tabrect.Height--;
                                RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(tabrect, Color.FromArgb(248, 251, 255), Color.Transparent, LinearGradientMode.ForwardDiagonal)), tabrect, 3f);

                                Region region = new Region();
                                region.Exclude(new Rectangle(tabrect.X - 4, 0, tabrect.Width + 1, 2));
                                tab.Region = region;
                            }
                            else if (ti == this.hoverindex)
                            {
                                tabrect.Width--;

                                if (ti == 0)
                                {
                                    tabrect.Height -= 3;
                                    RibbonControl.RenderSelection(e.Graphics, tabrect, 3f, this.pressed);
                                    tabrect.Height += 3;
                                }
                                else
                                    RibbonControl.RenderTopSelection(e.Graphics, tabrect, 3f, this.pressed);

                                tabrect.Width++;
                            }

                            tabrect.Height -= 2;

                            StringFormat sf = new StringFormat();
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;

                            e.Graphics.DrawString(tab.Text, tab.Font, new SolidBrush(Color.FromArgb(21, 66, 139)), tabrect, sf);

                            ti++;
                        }
                    }
                    break;
                case ColorScheme.Gray:
                    {
                        e.Graphics.Clear(Color.FromArgb(83, 83, 83));

                        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                        if (this.Height > 26)
                        {
                            RibbonControl.FillRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(5, this.Height - 20, this.Width - 10, 17), 3f);
                            RibbonControl.FillRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(5, this.Height - 20, this.Width - 10, 16), 3f);
                        }

                        int ti = 0;
                        foreach (TabPage tab in this.TabPages)
                        {
                            Rectangle tabrect = this.GetTabRect(ti);
                            tabrect.Height += 4;

                            StringFormat sf = new StringFormat();
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;

                            if (this.SelectedIndex > 0 && this.Height > 26 && tab == this.SelectedTab)
                            {
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(tabrect.X - 2, tabrect.Y, tabrect.Width + 4, tabrect.Height + 4), 3f);
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(16, Color.Black)), new Rectangle(tabrect.X - 1, tabrect.Y, tabrect.Width + 2, tabrect.Height + 4), 3f);
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new LinearGradientBrush(tabrect, Color.FromArgb(237, 238, 239), Color.FromArgb(206, 210, 217), LinearGradientMode.Vertical), tabrect, 3f);

                                RibbonControl.DrawTopRoundRectangle(e.Graphics, new Pen(Color.FromArgb(190, 190, 190)), tabrect, 3f);
                                tabrect.Offset(1, 1);
                                tabrect.Width -= 2;
                                tabrect.Height--;
                                RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(tabrect, Color.FromArgb(249, 249, 249), Color.Transparent, LinearGradientMode.ForwardDiagonal)), tabrect, 3f);

                                Region region = new Region();
                                region.Exclude(new Rectangle(tabrect.X - 4, 0, tabrect.Width + 1, 2));
                                tab.Region = region;

                                tabrect.Height -= 2;
                                e.Graphics.DrawString(tab.Text, tab.Font, new SolidBrush(Color.Black), tabrect, sf);
                            }
                            else if (ti == this.hoverindex)
                            {
                                tabrect.Width--;

                                if (ti == 0)
                                {
                                    tabrect.X += 2;
                                    tabrect.Width -= 2;
                                    tabrect.Height -= 3;
                                    RibbonControl.RenderSelection(e.Graphics, tabrect, 3f, this.pressed);
                                    tabrect.X -= 2;
                                    tabrect.Width += 2;
                                    tabrect.Height += 3;
                                }
                                else
                                    RibbonControl.RenderTopSelection(e.Graphics, tabrect, 3f, this.pressed);

                                tabrect.Width++;

                                tabrect.Height -= 2;
                                e.Graphics.DrawString(tab.Text, tab.Font, new SolidBrush(Color.Black), tabrect, sf);
                            }
                            else
                            {
                                tabrect.Height -= 2;
                                e.Graphics.DrawString(tab.Text, tab.Font, new SolidBrush(Color.White), tabrect, sf);
                            }

                            ti++;
                        }
                    }
                    break;
                case ColorScheme.Custom:
                    {
                        e.Graphics.Clear(RibbonControl.Color);

                        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                        if (this.Height > 26)
                        {
                            RibbonControl.FillRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(5, this.Height - 20, this.Width - 10, 17), 3f);
                            RibbonControl.FillRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(5, this.Height - 20, this.Width - 10, 16), 3f);
                        }

                        int ti = 0;
                        foreach (TabPage tab in this.TabPages)
                        {
                            Rectangle tabrect = this.GetTabRect(ti);
                            tabrect.Height += 4;

                            if (this.SelectedIndex > 0 && this.Height > 26 && tab == this.SelectedTab)
                            {
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(32, Color.Black)), new Rectangle(tabrect.X - 2, tabrect.Y, tabrect.Width + 4, tabrect.Height + 4), 3f);
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new SolidBrush(Color.FromArgb(16, Color.Black)), new Rectangle(tabrect.X - 1, tabrect.Y, tabrect.Width + 2, tabrect.Height + 4), 3f);
                                RibbonControl.FillTopRoundRectangle(e.Graphics, new LinearGradientBrush(tabrect, RibbonControl.GetColor(1.085), RibbonControl.GetColor(1.025), LinearGradientMode.Vertical), tabrect, 3f);

                                RibbonControl.DrawTopRoundRectangle(e.Graphics, new Pen(RibbonControl.GetColor(0.75)), tabrect, 3f);
                                tabrect.Offset(1, 1);
                                tabrect.Width -= 2;
                                tabrect.Height--;
                                RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(tabrect, RibbonControl.GetColor(1.105), Color.Transparent, LinearGradientMode.ForwardDiagonal)), tabrect, 3f);

                                Region region = new Region();
                                region.Exclude(new Rectangle(tabrect.X - 4, 0, tabrect.Width + 1, 2));
                                tab.Region = region;

                            }
                            else if (ti == this.hoverindex)
                            {
                                tabrect.Width--;

                                if (ti == 0)
                                {
                                    tabrect.Height -= 3;
                                    RibbonControl.RenderSelection(e.Graphics, tabrect, 3f, this.pressed);
                                    tabrect.Height += 3;
                                }
                                else
                                    RibbonControl.RenderTopSelection(e.Graphics, tabrect, 3f, this.pressed);

                                tabrect.Width++;
                            }

                            tabrect.Height -= 2;

                            StringFormat sf = new StringFormat();
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;

                            e.Graphics.DrawString(tab.Text, tab.Font, new SolidBrush(RibbonControl.TextColor), tabrect, sf);

                            ti++;
                        }
                    }
                    break;
            }
        }
    }

    public enum ColorScheme { Blue, Gray, Custom }
}