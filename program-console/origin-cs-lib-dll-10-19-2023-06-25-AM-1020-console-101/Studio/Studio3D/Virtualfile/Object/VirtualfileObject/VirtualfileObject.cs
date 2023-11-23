using Core;

namespace Core
{
    using System;

    public partial class Virtualfile
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(Virtualfile) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Filename) + ':' + ' ' + Filename,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ContentByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ContentByteArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ContentByteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ContentByteArray)
            });
        }
    }
}
