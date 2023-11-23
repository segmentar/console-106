using Core;

namespace Core
{
    using System;

    public partial struct Materialinflect
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialinflect) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(EscapeCharacterArray) + ':' + ' ' + ". . ." + ' ' + $"<{EscapeCharacterArray.Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(InflectString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(InflectString) + ':' + ' ' + InflectString.StringValueSafe,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(EscapeCharacterArray) + ':',
                String.Empty + String.Join('\n'.ToString(), EscapeCharacterArray)
            });
        }
    }
}
