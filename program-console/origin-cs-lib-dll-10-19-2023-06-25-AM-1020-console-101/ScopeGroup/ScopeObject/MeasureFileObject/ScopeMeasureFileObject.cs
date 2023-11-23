using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFile
    {
        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join("\r\n".ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureFile) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(PhysicalOffset) + ':' + ' ' + PhysicalOffset,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(RelateOffset) + ':' + ' ' + RelateOffset,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(VirtualOffset) + ':' + ' ' + VirtualOffset,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(LineNumber) + ':' + ' ' + LineNumber,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Character) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Character) + ':' + ' ' + $"<safe><<{Character.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(CharacterProof) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(CharacterProof) + ':' + ' ' + $"<safe><<{CharacterProof.CharacterValueSafe}>>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(Line) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(Line) + ':' + ' ' + $"<safe><{Line.StringValueSafe}>",
                String.Empty + '}'
            });
        }
    }
}
