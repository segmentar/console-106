using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFolder
    {
        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureFolder) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '}'
            });
        }
    }
}
