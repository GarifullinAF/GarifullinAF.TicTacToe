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

        private GameLogic gameLogic = new GameLogic();
        private GameField gameField = new GameField();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(0,0);
            gameLogic.TurnAction(positionPictureBox, pictureBox1, gameLogic, gameField, this);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(1, 0);
            gameLogic.TurnAction(positionPictureBox, pictureBox2, gameLogic, gameField, this);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(2, 0);
            gameLogic.TurnAction(positionPictureBox, pictureBox3, gameLogic, gameField, this);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(0, 1);
            gameLogic.TurnAction(positionPictureBox, pictureBox4, gameLogic, gameField, this);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(1, 1);
            gameLogic.TurnAction(positionPictureBox, pictureBox5, gameLogic, gameField, this);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(2, 1);
            gameLogic.TurnAction(positionPictureBox, pictureBox6, gameLogic, gameField, this);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(0, 2);
            gameLogic.TurnAction(positionPictureBox, pictureBox7, gameLogic, gameField, this);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(1, 2);
            gameLogic.TurnAction(positionPictureBox, pictureBox8, gameLogic, gameField, this);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GamePoint positionPictureBox = new GamePoint(2, 2);
            gameLogic.TurnAction(positionPictureBox, pictureBox9, gameLogic, gameField, this);
        }
    }
}
