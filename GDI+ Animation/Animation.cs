using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Animation
{
    public partial class fAnimation : Form
    {
        int X = 50;
        int Y = 50;
        int length = 10;
        double speed = 0.01;
        double angle = 0.0;
        Point centerPoint = new Point();
        Rectangle centerRec = new Rectangle();
        int radius = 100;

        public fAnimation()
        {
            InitializeComponent();
            tAnimation.Start();
            centerPoint = new Point(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2 + 30);
            centerRec = new Rectangle(centerPoint.X - 3, centerPoint.Y - 3, 6, 6);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(X, Y, length, length);
            Pen p = new Pen(Color.Black);

            g.DrawRectangle(p, rec);
            g.FillEllipse(new SolidBrush(Color.Black), centerRec);
        }

        private void tAnimation_Tick(object sender, EventArgs e)
        {
            angle += speed;
            if (angle == 361)
                angle = 0;

            X = (centerPoint.X + (int)Math.Floor(Math.Cos(angle) * radius))-length/2;
            Y = (centerPoint.Y + (int)Math.Floor(Math.Sin(angle) * radius))-length/2;
            this.Invalidate();
        }

        private void tbRadius_ValueChanged(object sender, EventArgs e)
        {
            radius = tbRadius.Value;
        }

        private void tbLength_ValueChanged(object sender, EventArgs e)
        {
            length = tbLength.Value;
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            double d = tbSpeed.Value;
            speed = d / 100;
        }
    }
}
