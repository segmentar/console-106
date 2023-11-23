using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scope
    {
        public static void Exit()
        {
            if (MeasureWait.ShouldGUI)
            {
                while (true)
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = MeasureWait.IsRunning is false;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    continue;
                }

                Application.Exit();
            }
            else
            {
                Application.Exit();
            }

            return;
        }
    }
}
