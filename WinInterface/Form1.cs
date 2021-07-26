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

        GameLogic GameLogic = new GameLogic();
        GameField GameField = new GameField();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(0,0);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox1);
                else GameLogic.DrawCircle(pictureBox1);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(1, 0);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox2);
                else GameLogic.DrawCircle(pictureBox2);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(2, 0);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox3);
                else GameLogic.DrawCircle(pictureBox3);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(0, 1);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox4);
                else GameLogic.DrawCircle(pictureBox4);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(1, 1);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox5);
                else GameLogic.DrawCircle(pictureBox5);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(2, 1);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox6);
                else GameLogic.DrawCircle(pictureBox6);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(0, 2);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox7);
                else GameLogic.DrawCircle(pictureBox7);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(1, 2);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox8);
                else GameLogic.DrawCircle(pictureBox8);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(2, 2);
            if (GameField.CheckSymbolEmpty(positionPictureBox))
            {
                GameField.GameResult[positionPictureBox.X, positionPictureBox.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    GameLogic.DrawCross(pictureBox9);
                else GameLogic.DrawCircle(pictureBox9);
            }
            if (GameField.CheckWinningCombinationcs())
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
            GameLogic.NextTurn();
        }
    }
}
