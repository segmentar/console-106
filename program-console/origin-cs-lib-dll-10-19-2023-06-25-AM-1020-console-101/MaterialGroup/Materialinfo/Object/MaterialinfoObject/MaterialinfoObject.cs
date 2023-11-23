using Core;

namespace Core
{
    using System;

    public partial class Materialinfo
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialinfo) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Name) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Name) + ':' + ' ' + $"<safe><<{Name.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(HeaderSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(HeaderSubstring) + ':' + ' ' + $"<safe><<{HeaderSubstring.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(FooterSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(FooterSubstring) + ':' + ' ' + $"<safe><<{FooterSubstring.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(EscapeCharacterArray) + ':' + ' ' + ". . ." + ' ' + $"<{EscapeCharacterArray.CharacterArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + "<safe>" + ' ' + nameof(EscapeCharacterArray) + ':',
                String.Empty + String.Join('\n'.ToString(), EscapeCharacterArray.CharacterArraySafe)
            });
        }
    }
}
