using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //DrawTicToe draw = new DrawTicToe();
            //draw.DrawCircle(pictureBox1);
            var control = pictureBox1;
            Graphics g = control.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 10);
            g.DrawEllipse(myPen, new Rectangle((int)myPen.Width, (int)myPen.Width, control.Width - (int)myPen.Width * 2, control.Height - (int)myPen.Width * 2));
            myPen.Dispose();
            g.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DrawTicToe draw = new DrawTicToe();
            draw.DrawCross(pictureBox2);
        }
    }
}
