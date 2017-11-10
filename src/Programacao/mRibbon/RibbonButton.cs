using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mRibbon
{
    public class RibbonButton : Label
    {
        public event RibbonPopupEventHandler OnPopup;

        private bool isflat;
        private bool ispressed, hover, pressed;

        public RibbonButton()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.Margin = new Padding(1);
            this.Padding = new Padding(2);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.isflat = true;
            this.ispressed = false;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            this.AutoSize = false;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (OnPopup != null)
                OnPopup(this);
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
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            this.hover = true;
            this.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.hover = false;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            if (this.hover)
                RibbonControl.RenderSelection(e.Graphics, rect, 2f, this.pressed);
            else if (this.ispressed)
                RibbonControl.RenderSelection(e.Graphics, rect, 2f, true);
            else if (!this.isflat)
            {
                switch (RibbonControl.ColorScheme)
                {
                    case ColorScheme.Blue:
                        {
                            Color[] col = new Color[] { Color.FromArgb(225, 234, 245), Color.FromArgb(209, 223, 240), Color.FromArgb(199, 216, 237), Color.FromArgb(231, 242, 255) };
                            float[] pos = new float[] { 0.0f, 0.2f, 0.2f, 1.0f };

                            ColorBlend blend = new ColorBlend();
                            blend.Colors = col;
                            blend.Positions = pos;
                            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                            brush.InterpolationColors = blend;

                            RibbonControl.FillRoundRectangle(e.Graphics, brush, rect, 2f);

                            RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(Color.FromArgb(141, 178, 227)), rect, 2f);
                            rect.Offset(1, 1);
                            rect.Width -= 2;
                            rect.Height -= 2;
                            RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(rect, Color.FromArgb(231, 239, 248), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rect, 2f);
                        }
                        break;
                    case ColorScheme.Gray:
                        {
                            Color[] col = new Color[] { Color.FromArgb(210, 214, 221), Color.FromArgb(193, 198, 207), Color.FromArgb(180, 187, 197), Color.FromArgb(231, 240, 241) };
                            float[] pos = new float[] { 0.0f, 0.2f, 0.2f, 1.0f };

                            ColorBlend blend = new ColorBlend();
                            blend.Colors = col;
                            blend.Positions = pos;
                            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                            brush.InterpolationColors = blend;

                            RibbonControl.FillRoundRectangle(e.Graphics, brush, rect, 2f);

                            RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(Color.FromArgb(190, 190, 190)), rect, 2f);
                            rect.Offset(1, 1);
                            rect.Width -= 2;
                            rect.Height -= 2;
                            RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(rect, Color.FromArgb(231, 233, 237), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rect, 2f);
                        }
                        break;
                    case ColorScheme.Custom:
                        {
                            Color[] col = new Color[] { RibbonControl.GetColor(1.025), RibbonControl.GetColor(1.0), RibbonControl.GetColor(0.975), RibbonControl.GetColor(1.075) };
                            float[] pos = new float[] { 0.0f, 0.2f, 0.2f, 1.0f };

                            ColorBlend blend = new ColorBlend();
                            blend.Colors = col;
                            blend.Positions = pos;
                            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                            brush.InterpolationColors = blend;

                            RibbonControl.FillRoundRectangle(e.Graphics, brush, rect, 2f);

                            RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(RibbonControl.GetColor(0.75)), rect, 2f);
                            rect.Offset(1, 1);
                            rect.Width -= 2;
                            rect.Height -= 2;
                            RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(rect, RibbonControl.GetColor(1.05), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rect, 2f);
                        }
                        break;
                }
            }

            base.OnPaint(e);
        }

        public bool IsFlat
        {
            get { return this.isflat; }
            set { this.isflat = value; }
        }
        public bool IsPressed
        {
            get { return this.ispressed; }
            set { this.ispressed = value; }
        }
    }
}
