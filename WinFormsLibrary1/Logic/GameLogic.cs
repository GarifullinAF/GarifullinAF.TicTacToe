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
            Graphics graphic = control.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 10);
            graphic.DrawEllipse(myPen, new Rectangle((int)myPen.Width, (int)myPen.Width, control.Width - (int)myPen.Width * 2, control.Height - (int)myPen.Width * 2));
            myPen.Dispose();
            graphic.Dispose();
        }

        /// <summary>
        /// Рисует крестик в переданом контроле
        /// </summary>
        /// <param name="control"></param>
        public void DrawCross(Control control)
        {
            Graphics graphic = control.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 10);
            graphic.DrawLine(myPen, new Point((int)myPen.Width, (int)myPen.Width), new Point(control.Width - (int)myPen.Width, control.Height - (int)myPen.Width));
            graphic.DrawLine(myPen, new Point((int)myPen.Width, control.Height - (int)myPen.Width), new Point(control.Width - (int)myPen.Width, (int)myPen.Width));
            myPen.Dispose();
            graphic.Dispose();
        }

        /// <summary>
        /// Передает ход следующему игроку
        /// </summary>
        public void NextTurn()
        {
            if (CurrentTurn == GameSymbols.Circle) CurrentTurn = GameSymbols.Cross;
            else CurrentTurn = GameSymbols.Circle;
        }

        public void TurnAction(GamePoint controlsPoint, Control control, GameLogic logic, GameField field, Form gameForm)
        {
            if (field.CheckSymbolEmpty(controlsPoint))
            {
                field.GameResult[controlsPoint.X, controlsPoint.Y] = GameLogic.CurrentTurn;
                if (GameLogic.CurrentTurn == GameSymbols.Cross)
                    logic.DrawCross(control);
                else logic.DrawCircle(control);
            }
            if (field.CheckWinningCombinationcs())
            {
                MessageBox.Show($"{GameLogic.CurrentTurn} win!!!");
                logic.GameReplayRequest(field, gameForm);
            }
            logic.NextTurn();
           
        }

        public void GameReplayRequest(GameField field, Form gameForm)
        {
            string message = "Еще партейку?";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                field.RefreshGameResult();
                gameForm.Enabled = false;
                gameForm.Enabled = true;
                GameLogic.CurrentTurn = GameSymbols.Cross;
            }
            else gameForm.Close();
        }
    }
}

