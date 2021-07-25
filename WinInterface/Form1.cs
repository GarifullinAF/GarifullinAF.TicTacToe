using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLibrary1;


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
            GamePoint positionBox1 = new GamePoint(0,0);
            ////Проверка на то, что символ в поле еще не устанавливался
            //if (newGame.gameResult[positionBox1.X,positionBox1.Y] == GameSymbols.Empty)
            //{
            //    newGame.gameResult[positionBox1.X, positionBox1.Y] = DrawTicToe.CurrentTurn;
            //    if (DrawTicToe.CurrentTurn == GameSymbols.Cross)
            //    {
            //        draw.DrawCross(pictureBox1);
            //    }
            //    else
            //    {
            //        draw.DrawCircle(pictureBox1);
            //    }
            //    if (WinningCombinations.CheckWinningCombinationcs(newGame.gameResult))
            //    {
            //        MessageBox.Show("Есть победитель");
            //    };
            //}
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(1, 0);
        
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(2, 0);
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(0, 1);
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(1, 1);
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(2, 1);
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(0, 2);
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(1, 2);
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GamePoint positionBox1 = new GamePoint(2, 2);
            
        }
    }
}
