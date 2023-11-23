using Core;

namespace Core
{
    using System;

    public partial class ExpressionSequence
    {

        [IntentionalShortMethod]
        public static void Debug(ExpressionStringSafe IdentityStringSafe___VALUE, Object ObjectIdentity__VALUE, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            Expression.Render($"{ExpressionCode.RenderPath.Core_Expression_Debug}-{nameof(Expression)}Debug", String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(ExpressionSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdentityStringSafe___VALUE) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IdentityStringSafe___VALUE) + ':' + ' ' + $"<safe><<{IdentityStringSafe___VALUE.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ObjectIdentity__VALUE) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectIdentity__VALUE) + ':',
                String.Empty + ObjectIdentity__VALUE
            }));

            return;
        }
    }
}
