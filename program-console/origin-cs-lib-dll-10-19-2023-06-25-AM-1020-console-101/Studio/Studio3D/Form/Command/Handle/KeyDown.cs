using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Command
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = Context.ReferencePage.HasPrompt is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var carriage_return = Convert.ToChar(13);

            Boolean isEnterCheck;

            isEnterCheck = e.KeyValue.Equals(carriage_return) is true;

            if (isEnterCheck is true)
            {
                Prompt.Instance.Select();
            }
            else
                "false".ToString();

            base.OnKeyDown(e);
        }
    }
}
