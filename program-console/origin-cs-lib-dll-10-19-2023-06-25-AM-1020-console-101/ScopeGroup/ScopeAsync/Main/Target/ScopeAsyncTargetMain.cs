using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scope
    {
        public static void ScopeMainTarget()
        {
            try
            {
                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);

                ApplicationContext applicationContext;

                applicationContext = new ScopeDisplayContext().Show();

                Application.Run(applicationContext);

            }
            catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return;
        }
    }
}
