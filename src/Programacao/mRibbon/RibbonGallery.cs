using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mRibbon
{
    public class RibbonGallery : FlowLayoutPanel
    {
        public RibbonGallery()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.Margin = new Padding(1);
            this.Padding = new Padding(1);
            this.Size = new Size(100, 50);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            switch (RibbonControl.ColorScheme)
            {
                case ColorScheme.Blue:
                    {
                        e.Graphics.Clear(Color.FromArgb(212, 230, 248));
                        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(185, 208, 237)), rect);
                    }
                    break;
                case ColorScheme.Gray:
                    {
                        e.Graphics.Clear(Color.FromArgb(218, 226, 226));
                        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(172, 172, 172)), rect);
                    }
                    break;
                case ColorScheme.Custom:
                    {
                        e.Graphics.Clear(RibbonControl.GetColor(1.031));
                        e.Graphics.DrawRectangle(new Pen(RibbonControl.GetColor(0.946)), rect);
                    }
                    break;
            }
        }
    }
}
