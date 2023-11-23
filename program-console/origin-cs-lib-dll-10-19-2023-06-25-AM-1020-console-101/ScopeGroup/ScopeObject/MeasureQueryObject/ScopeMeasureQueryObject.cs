using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureQuery
    {
        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureQuery) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(LocalLineArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{LocalLineArrayList.Count}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(GlobalLineArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{GlobalLineArrayList.Count}>", 
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ScopefileArrayList) + ':' + ' ' + "<hidden>" + ' ' + $"<{ScopefileArrayList.Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LocalLineArrayList) + ':',
                String.Empty + String.Join("\r\n".ToString(), LocalLineArrayList.ToArray()),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(GlobalLineArrayList) + ':',
                String.Empty + String.Join("\r\n".ToString(), GlobalLineArrayList.ToArray())
            });
        }
    }
}
