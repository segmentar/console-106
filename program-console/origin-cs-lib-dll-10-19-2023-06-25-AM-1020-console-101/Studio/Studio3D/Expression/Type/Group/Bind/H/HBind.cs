using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void HBind(String[] array_SPLIT)
        {
            var boolean_safe__EQUAL_OR_MORE_THAN = (array_SPLIT.Length >= 2) is true;

            Boolean shouldRenderCheck;

            shouldRenderCheck = boolean_safe__EQUAL_OR_MORE_THAN is false;

            if (shouldRenderCheck is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryEstelScript.Core_EstelScript_Fatal}-{nameof(HBind)}", String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(HBind) + ' ' + '{',
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(boolean_safe__EQUAL_OR_MORE_THAN) + ':' + ' ' + boolean_safe__EQUAL_OR_MORE_THAN,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(shouldRenderCheck) + ':' + ' ' + shouldRenderCheck,
                    String.Empty + '}'
                }));

                return;
            }
            else
                "false".ToString();

            var second = array_SPLIT[1];

            var entity__UNDER_SCORE = Convert.ToChar(95);

            var separator = new String[] { entity__UNDER_SCORE.ToString() };

            var split = second.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var entity__WHITE_SPACE = Convert.ToChar(32);

            var join = String.Join(entity__WHITE_SPACE.ToString(), split);

            var result = join;

            Bind(result);

            return;
        }
    }
}
