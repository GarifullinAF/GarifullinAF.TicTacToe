using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsLibrary1
{
    public class GameLogic
    {
        /// <summary>
        /// Символ игрока, чей сейчас ход
        /// </summary>
        public static GameSymbols CurrentTurn = GameSymbols.Cross;

        /// <summary>
        /// Рисует круг в переданом контроле
        /// </summary>
        /// <param name="control"></param>
        public void DrawCircle(Control control)
        {
            Graphics g = control.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 10);
            g.DrawEllipse(myPen, new Rectangle((int)myPen.Width, (int)myPen.Width, control.Width - (int)myPen.Width * 2, control.Height - (int)myPen.Width * 2));
            myPen.Dispose();
            g.Dispose();
        }

        /// <summary>
        /// Рисует крестик в переданом контроле
        /// </summary>
        /// <param name="control"></param>
        public void DrawCross(Control control)
        {
            Graphics g = control.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 10);
            g.DrawLine(myPen, new Point((int)myPen.Width, (int)myPen.Width), new Point(control.Width - (int)myPen.Width, control.Height - (int)myPen.Width));
            g.DrawLine(myPen, new Point((int)myPen.Width, control.Height - (int)myPen.Width), new Point(control.Width - (int)myPen.Width, (int)myPen.Width));
            myPen.Dispose();
            g.Dispose();
        }

        /// <summary>
        /// Передает ход следующему игроку
        /// </summary>
        public void NextTurn()
        {
            if (CurrentTurn == GameSymbols.Circle) CurrentTurn = GameSymbols.Cross;
            else CurrentTurn = GameSymbols.Circle;
        }
    }
}

