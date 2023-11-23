using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class ConsoleLJ
    {
        public void Style(ConsoleLJWCode.GUIStyle styleCode, Object objectItem)
        {
            String reflectString;

            reflectString = objectItem.ToString();

            var reflect_FONT = default(Font);

            var reflect_COLOR = default(Color);

            try
            {
                reflect_FONT = (Font)objectItem;

            } catch (Exception exception)
            {
                exception.ToString();
            }

            try
            {
                reflect_COLOR = Color.FromName(reflectString);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            switch (styleCode)
            {
                case ConsoleLJWCode.GUIStyle.CommandBackColor:
                    Command.Instance.BackColor = reflect_COLOR;
                    break;

                case ConsoleLJWCode.GUIStyle.CommandForeColor:
                    Command.Instance.ForeColor = reflect_COLOR;
                    break;

                case ConsoleLJWCode.GUIStyle.CommandFont:
                    Command.Instance.Font = reflect_FONT;
                    break;

                case ConsoleLJWCode.GUIStyle.PromptBackColor:
                    Prompt.Instance.BackColor = reflect_COLOR;
                    break;

                case ConsoleLJWCode.GUIStyle.PromptForeColor:
                    Prompt.Instance.ForeColor = reflect_COLOR;
                    break;

                case ConsoleLJWCode.GUIStyle.PromptFont:
                    Prompt.Instance.Font = reflect_FONT;
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
