using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        [IntentionalShortMethod]
        public void HBindInt32(String[] array_SPLIT)
        {
            var boolean_safe__EQUAL_OR_MORE_THAN = (array_SPLIT.Length >= 2) is true;

            Boolean shouldRenderCheck;

            shouldRenderCheck = boolean_safe__EQUAL_OR_MORE_THAN is false;

            if (shouldRenderCheck is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryEstelScript.Core_EstelScript_Fatal}-{nameof(HBindInt32)}", String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(HBindInt32) + ' ' + '{',
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(boolean_safe__EQUAL_OR_MORE_THAN) + ':' + ' ' + boolean_safe__EQUAL_OR_MORE_THAN,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(shouldRenderCheck) + ':' + ' ' + shouldRenderCheck,
                    String.Empty + '}'
                }));

                return;
            }
            else
                "false".ToString();

            var second = array_SPLIT[1];

            var format = ForgeDashlessFormat(second);

            BindInt32(format);

            return;
        }
    }
}
