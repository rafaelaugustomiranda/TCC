using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mRibbon
{
    public class RibbonTab : TabPage
    {
        public RibbonTab()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
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

                        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                        Color[] col = new Color[] { Color.FromArgb(225, 234, 245), Color.FromArgb(209, 223, 240), Color.FromArgb(199, 216, 237), Color.FromArgb(231, 242, 255) };
                        float[] pos = new float[] { 0.0f, 0.2f, 0.2f, 1.0f };

                        ColorBlend blend = new ColorBlend();
                        blend.Colors = col;
                        blend.Positions = pos;
                        LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                        brush.InterpolationColors = blend;

                        RibbonControl.FillRoundRectangle(e.Graphics, brush, rect, 3f);

                        RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(Color.FromArgb(141, 178, 227)), rect, 3f);
                        rect.Offset(1, 1);
                        rect.Width -= 2;
                        rect.Height -= 2;
                        RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(rect, Color.FromArgb(231, 239, 248), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rect, 3f);
                    }
                    break;
                case ColorScheme.Gray:
                    {
                        e.Graphics.Clear(Color.FromArgb(83, 83, 83));

                        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                        Color[] col = new Color[] { Color.FromArgb(210, 214, 221), Color.FromArgb(193, 198, 207), Color.FromArgb(180, 187, 197), Color.FromArgb(231, 240, 241) };
                        float[] pos = new float[] { 0.0f, 0.2f, 0.2f, 1.0f };

                        ColorBlend blend = new ColorBlend();
                        blend.Colors = col;
                        blend.Positions = pos;
                        LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                        brush.InterpolationColors = blend;

                        RibbonControl.FillRoundRectangle(e.Graphics, brush, rect, 3f);

                        RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(Color.FromArgb(190, 190, 190)), rect, 3f);
                        rect.Offset(1, 1);
                        rect.Width -= 2;
                        rect.Height -= 2;
                        RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(rect, Color.FromArgb(231, 233, 237), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rect, 3f);
                    }
                    break;
                case ColorScheme.Custom:
                    {
                        e.Graphics.Clear(RibbonControl.Color);

                        Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                        Color[] col = new Color[] { RibbonControl.GetColor(1.025), RibbonControl.GetColor(1.0), RibbonControl.GetColor(0.975), RibbonControl.GetColor(1.075) };
                        float[] pos = new float[] { 0.0f, 0.2f, 0.2f, 1.0f };

                        ColorBlend blend = new ColorBlend();
                        blend.Colors = col;
                        blend.Positions = pos;
                        LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Vertical);
                        brush.InterpolationColors = blend;

                        RibbonControl.FillRoundRectangle(e.Graphics, brush, rect, 3f);

                        RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(RibbonControl.GetColor(0.75)), rect, 3f);
                        rect.Offset(1, 1);
                        rect.Width -= 2;
                        rect.Height -= 2;
                        RibbonControl.DrawRoundRectangle(e.Graphics, new Pen(new LinearGradientBrush(rect, RibbonControl.GetColor(1.05), Color.Transparent, LinearGradientMode.ForwardDiagonal)), rect, 3f);
                    }
                    break;
            }
        }
    }
}