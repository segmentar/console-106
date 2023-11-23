using Core;

namespace Core
{
    using System;

    public partial class ScopeFatal
    {
        [ScopeIntentionalShortMethod]
        private String ActionDescriptor()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ScopeFatal) + ' ' + "::" + ' ' + GetType().Name + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(InformationArray) + ':' + ' ' + ". . ." + ' ' + $"<{InformationArray.Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Exception) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(InformationArray) + ':',
                String.Empty + String.Join('\n'.ToString(), InformationArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Exception) + ':',
                String.Empty + ForgeExceptionString(this)
            });
        }
    }
}
