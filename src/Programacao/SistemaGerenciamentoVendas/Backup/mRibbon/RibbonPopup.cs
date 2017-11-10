using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace mRibbon
{
    public class RibbonPopup : Form
    {
        public RibbonPopup()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;

            this.BackColor = Color.FromArgb(250, 250, 250);
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);

            this.Close();
        }
    }

    public delegate void RibbonPopupEventHandler(object sender);
}
