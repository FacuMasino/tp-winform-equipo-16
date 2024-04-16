// Autor: vpavlevski
// Tomado y adaptado de: https://github.com/DevInDeep/RoundControls/blob/master/RoundTextBoxProject/RoundControl.cs

using RoundTextBoxProject.Extensions;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class RoundPanel : Panel
    {
        private int _radius = 10;
        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                Invalidate();
            }
        }

        private SolidBrush _backgroundBrush = new SolidBrush(SystemColors.Control);
        private Color _backgroundColor = SystemColors.Control;
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundBrush = new SolidBrush(_backgroundColor = value);
                Invalidate();
            }
        }

        private Color _borderColor = SystemColors.Control;
        private Pen _borderPen = new Pen(ControlPaint.Light(SystemColors.Control, 0.0f), 0);
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                _borderPen = new Pen(ControlPaint.Light(_borderColor, 0.0f), _borderWidth);
                Invalidate();
            }
        }

        private float _borderWidth = 1.0f;
        public float BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                _borderPen = new Pen(ControlPaint.Light(_borderColor, 0.0f), _borderWidth);
                Invalidate();
            }
        }

        public RoundPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            drawBorder(g);
            drawBackground(g);
        }

        private void drawBorder(Graphics g) =>
            g.DrawRoundedRectangle(
                _borderPen,
                _borderWidth / 2,
                _borderWidth / 2,
                Width - _borderWidth,
                Height - _borderWidth,
                _radius
            );

        private void drawBackground(Graphics g) =>
            g.FillRoundedRectangle(
                _backgroundBrush,
                _borderWidth / 2,
                _borderWidth / 2,
                Width - _borderWidth,
                Height - _borderWidth,
                _radius
            );
    }
}
