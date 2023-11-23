using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureValue
    {

        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureValue) + ' ' + ':',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(MaterialHeaderSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(MaterialHeaderSubstring) + ':' + ' ' + $"<safe><<{MaterialHeaderSubstring.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(MaterialFooterSubstring) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(MaterialFooterSubstring) + ':' + ' ' + $"<safe><<{MaterialFooterSubstring.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(LocalLineMultilineCount) + ':' + ' ' + LocalLineMultilineCount,
                String.Empty + '}'
            });
        }
    }
}
