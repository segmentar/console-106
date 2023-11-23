using Core;

namespace Core
{
    using System;

    internal partial class MaterialreflectSequence
    {
        [MaterialIntentionalShortMethod]
        internal static void Debug(MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            Material.Render($"{MaterialreflectCode.RenderPath.Core_Materialreflect_Debug}-{nameof(Materialreflect)}Debug", String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialreflect) + ' ' + "::" + ' ' + nameof(MaterialreflectSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(StringFormat__VALUE) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(EscapeCharacter__ARRAY) + ':' + ' ' + ". . ." + $"<{EscapeCharacter__ARRAY.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(StringFormat__VALUE) + ':',
                String.Empty + StringFormat__VALUE,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + $"<safe><<{nameof(EscapeCharacter__ARRAY)}>>" + ':',
                String.Empty + String.Join('\n'.ToString(), Material.SolidCharacterArray(EscapeCharacter__ARRAY))
            }));

            return;
        }
    }
}
