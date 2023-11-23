using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Interop
    {
        public static void Finf08IL()
        {
            Boolean isDefaultCheck, shouldReturnCheck;

            isDefaultCheck = (InteropSpecialize.GetStudioDirectory(true) == default) is true;

            shouldReturnCheck = isDefaultCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Form form;

            form = new Form();

            form.Text = "Error";

            form.StartPosition = FormStartPosition.CenterScreen;

            TextBox textBox;

            textBox = new TextBox();

            textBox.Multiline = true;

            textBox.Dock = DockStyle.Fill;

            var descriptor = new String[] {

                String.Empty + "studio directory is missing,",
                String.Empty + "make a (.txt) file,",
                String.Empty + "its name must be `Studio`",
                String.Empty + "with the only content(s) being,",
                String.Empty + "the full name path of the folder, that is",
                String.Empty + "the studio folder, that is",
                String.Empty + "under origin folder, that is",
                String.Empty + "under the solution swash project folder"
            };

            var join = String.Join("\r\n", descriptor);

            textBox.Text = join;

            textBox.TextAlign = HorizontalAlignment.Center;

            form.Controls.Add(textBox);

            Application.Run(form);

            Environment.Exit(0);
           
            return;
        }
    }
}
