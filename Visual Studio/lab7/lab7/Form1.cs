using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        private const double startX = 3.8;
        private const double endX = 7.6;
        private const double deltaX = 0.6;

        public Form1()
        {
            InitializeComponent();
            this.Resize += new EventHandler(FormResize);
            this.Paint += new PaintEventHandler(DrawGraph);
        }

        private void FormResize(object sender, EventArgs e)
        {
            this.Invalidate();  
        }

        private void DrawGraph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            double scaleX = width / (endX - startX);
            double scaleY = height / 2.0;

            Pen pen = new Pen(Color.Blue, 2);

            for (double x = startX; x <= endX; x += deltaX)
            {
                double y = Math.Pow(Math.Cos(x), 2) / (Math.Pow(x, 2) + 1);
                double nextX = x + deltaX;
                double nextY = Math.Pow(Math.Cos(nextX), 2) / (Math.Pow(nextX, 2) + 1);

                int x1 = (int)((x - startX) * scaleX);
                int y1 = height - (int)(y * scaleY);
                int x2 = (int)((nextX - startX) * scaleX);
                int y2 = height - (int)(nextY * scaleY);

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }
    }
}
