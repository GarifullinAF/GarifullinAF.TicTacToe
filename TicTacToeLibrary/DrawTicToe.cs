using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeLibrary
{
    public class DrawTicToe
    {
        public static GameSymbols CurrentTurn = GameSymbols.Cross;
        public void DrawCircle (Control control)
        {
            Graphics g = control.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 10);
            g.DrawEllipse(myPen, new Rectangle((int)myPen.Width, (int)myPen.Width, control.Width - (int)myPen.Width * 2, control.Height - (int)myPen.Width * 2));
            myPen.Dispose();
            g.Dispose();
            CurrentTurn = GameSymbols.Cross;
        }

        public void DrawCross (Control control)
        {
            Graphics g = control.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 10);
            g.DrawLine(myPen, new Point((int)myPen.Width, (int)myPen.Width), new Point(control.Width - (int)myPen.Width, control.Height - (int)myPen.Width));
            g.DrawLine(myPen, new Point((int)myPen.Width, control.Height - (int)myPen.Width), new Point(control.Width - (int)myPen.Width, (int)myPen.Width));
            myPen.Dispose();
            g.Dispose();
            CurrentTurn = GameSymbols.Circle;
        }
    }
}
