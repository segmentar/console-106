using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureInstruction
    {
        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureInstruction) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FilePointerRelocate) + ':' + ' ' + FilePointerRelocate,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(PhysicalOffsetRelocate) + ':' + ' ' + PhysicalOffsetRelocate,
                String.Empty + '}'
            });
        }
    }
}
