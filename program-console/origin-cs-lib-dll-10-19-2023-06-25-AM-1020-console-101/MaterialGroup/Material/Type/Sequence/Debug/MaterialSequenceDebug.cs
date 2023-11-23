using Core;

namespace Core
{
    using System;

    internal partial class MaterialSequence
    {
        [MaterialIntentionalShortMethod]
        internal static void Debug(MaterialStringSplitcharacter HeaderSplitcharacter___VALUE, String BodySubstring__VALUE, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            var join = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Material) + ' ' + "::" + ' ' + nameof(MaterialSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(HeaderSplitcharacter___VALUE) + ':' + ' ' + HeaderSplitcharacter___VALUE.StringValue,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(HeaderSplitcharacter___VALUE) + ':' + ' ' + HeaderSplitcharacter___VALUE.StringValueSplit,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(BodySubstring__VALUE) + ':' + ' ' + BodySubstring__VALUE,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}'
            });

            Material.Render($"{MaterialCode.RenderPath.Core_Material_Debug}-{nameof(Material)}Debug", join);

            return;
        }
    }
}
