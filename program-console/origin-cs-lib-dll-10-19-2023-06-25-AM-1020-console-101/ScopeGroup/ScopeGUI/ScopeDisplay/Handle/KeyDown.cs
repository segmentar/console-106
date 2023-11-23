using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ScopeDisplay
    {
        public static void HandleKeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode is Keys.P)
            {
                Scope.DirectionPause();

                if (Scope.MeasureWait.IsPause is true)
                {
                    Scope.DirectionTemplate();
                }
                else
                    "false".ToString();

                if (Scope.MeasureWait.IsPause is false && (Scope.Template == default) is false)
                {
                    Scope.DirectionRestore(true);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.F)
            {
                Scope.DirectionForward();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.G)
            {
                Scope.DirectionForwardFile();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.B)
            {
                Scope.DirectionBackward();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.N)
            {
                Scope.DirectionBackwardFile();
            }
            else
                "false".ToString();

            if (e.KeyData is Keys.S)
            {
                Scope.DirectionStart();
            }
            else
                "false".ToString();

            if (e.KeyData is Keys.E)
            {
                Scope.DirectionEnd();
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.R)
            {
                Scope.DirectionRender(true);
            }
            else
                "false".ToString();

            if (e.KeyCode is Keys.Q)
            {
                Scope.DirectionQuit();
            }
            else
                "false".ToString();

            return;
        }
    }
}
