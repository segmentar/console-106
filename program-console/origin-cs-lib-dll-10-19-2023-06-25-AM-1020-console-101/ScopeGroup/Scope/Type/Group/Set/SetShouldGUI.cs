using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void SetShouldGUI(Boolean answer_GUI_should)
        {
            if (answer_GUI_should is false)
            {
                return;
            }
            else
                "false".ToString();

            MeasureWait.ShouldGUI = true;

            return;
        }
    }
}
