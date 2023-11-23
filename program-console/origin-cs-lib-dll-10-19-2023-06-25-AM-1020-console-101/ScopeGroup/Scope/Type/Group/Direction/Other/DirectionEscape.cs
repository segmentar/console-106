using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scope
    {
        public static void DirectionQuit()
        {
            if (MeasureWait.IsRunning)
            {
                MeasureWait.IsRunning = false;
            }
            else
            {
                Application.Exit();
            }            

            return;
        }
    }
}
