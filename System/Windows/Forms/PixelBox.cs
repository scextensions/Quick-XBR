using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    internal class PixelBox : PictureBox
    {
        #region Initialization

        public PixelBox()
        {
            InterpolationMode = InterpolationMode.NearestNeighbor;
        }
        #endregion

        #region Properties
        [Category("Behavior")]
        [DefaultValue(InterpolationMode.Default)]
        public InterpolationMode InterpolationMode { get; set; }
        #endregion

        #region Overrides of PictureBox
        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.InterpolationMode = InterpolationMode;
            base.OnPaint(pe);
        }
        #endregion
    }
}
