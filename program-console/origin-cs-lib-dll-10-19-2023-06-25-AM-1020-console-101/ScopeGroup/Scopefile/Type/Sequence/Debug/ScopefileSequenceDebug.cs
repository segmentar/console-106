using Core;

namespace Core
{
    using System;

    public partial class ScopefileSequence
    {
        public static void Debug(Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            var join = String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopefile) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}'
            });

            Scope.Render($"{ScopeCode.RenderPath.Core_Scope_Debug}-{nameof(Scopefile)}Debug", join);

            return;
        }
    }
}
