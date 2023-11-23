using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Expression) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StringIdentity) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StringIdentity) + ':' + ' ' + $"<safe><<{StringIdentity.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ObjectIdentity) + ':' + ' ' + ". . .",
                String.Empty + '.' + "information-raw",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ExpressionArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{ExpressionArrayList.Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectIdentity) + ':',
                String.Empty + ObjectIdentity,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ExpressionArrayList) + ':',
                String.Empty + String.Join('\n'.ToString(), ExpressionArrayList.ToArray()),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + ". . . . ." + ':',
                String.Empty + ForgeRepresentString(this, 1)
            });
        }
    }
}
