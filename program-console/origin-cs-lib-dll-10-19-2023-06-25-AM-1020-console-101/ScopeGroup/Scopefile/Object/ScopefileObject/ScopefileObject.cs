using Core;

namespace Core
{
    using System;

    public partial class Scopefile
    {
        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopefile) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug, 
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Filename) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Filename) + ':' + ' ' + $"<safe><<{Filename.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(LocalLineArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(LocalLineArray) + ':' + ' ' + ". . ." + ' ' + $"<{LocalLineArray.StringArrayValue.Length}>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(GlobalLineArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(GlobalLineArray) + ':' + ' ' + ". . ." + ' ' + $"<{GlobalLineArray.StringArrayValue.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + "<safe>" + ' ' + nameof(LocalLineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), LocalLineArray.StringArrayValueSafe),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + "<safe>" + ' ' + nameof(GlobalLineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), GlobalLineArray.StringArrayValueSafe)
            });
        }
    }
}
