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

        List<int> resultTurns = new List<int>();
        DrawTicToe draw = new DrawTicToe();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(1))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox1);
                else draw.DrawCircle(pictureBox1);
                resultTurns.Add(1);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(2))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox2);
                else draw.DrawCircle(pictureBox2);
                resultTurns.Add(2);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(3))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox3);
                else draw.DrawCircle(pictureBox3);
                resultTurns.Add(3);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(4))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox4);
                else draw.DrawCircle(pictureBox4);
                resultTurns.Add(4);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(5))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox5);
                else draw.DrawCircle(pictureBox5);
                resultTurns.Add(5);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(6))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox6);
                else draw.DrawCircle(pictureBox6);
                resultTurns.Add(6);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(7))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox7);
                else draw.DrawCircle(pictureBox7);
                resultTurns.Add(7);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(8))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox8);
                else draw.DrawCircle(pictureBox8);
                resultTurns.Add(8);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!resultTurns.Contains(9))
            {
                if (DrawTicToe.CurrentTurn == 0) draw.DrawCross(pictureBox9);
                else draw.DrawCircle(pictureBox9);
                resultTurns.Add(9);
            }
        }
    }
}
