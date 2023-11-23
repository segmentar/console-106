using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJSequence
    {

        [IntentionalShortMethod]
        public static void Debug(Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(ConsoleLJ) + ' ' + "::" + ' ' + nameof(ConsoleLJSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            });

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Debug}-{nameof(ConsoleLJ)}Debug", descriptor);

            return;
        }
    }
}
