using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Material) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(HeaderSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(HeaderSubstring) + ':' + ' ' + $"<safe><<{HeaderSubstring.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(FooterSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(FooterSubstring) + ':' + ' ' + $"<safe><<{FooterSubstring.StringValueSafe}>>",
                String.Empty + '.' + "information-raw",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(EscapeCharacterArray) + ':' + ' ' + ". . ." + ' ' + $"<{EscapeCharacterArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(EscapeCharacterArray) + ':',
                String.Empty + String.Join('\n'.ToString(), EscapeCharacterArray)
            });
        }
    }
}
