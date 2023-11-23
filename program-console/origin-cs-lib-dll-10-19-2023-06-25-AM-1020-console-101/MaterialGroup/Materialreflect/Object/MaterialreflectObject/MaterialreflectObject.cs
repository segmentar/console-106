using Core;

namespace Core
{
    using System;

    internal partial class Materialreflect
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Materialreflect) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Material) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(InputString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(InputString) + ':' + ' ' + $"<safe><<{InputString.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(EscapeCharacterArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(EscapeCharacterArray) + ':' + ' ' + ". . ." + $"<{EscapeCharacterArray.CharacterArray.Length}>",
                String.Empty + '.' + "information-raw",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(OutputString) + ':' + ' ' + OutputString,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Material) + ':',
                String.Empty + Material,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + $"<safe><<{nameof(EscapeCharacterArray)}>>" + ':',
                String.Empty + String.Join('\n'.ToString(), EscapeCharacterArray.CharacterArraySafe)
            });
        }
    }
}
