using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetProofCharacter()
        {
            MeasureFile.CharacterProof = GetCharacterFromVirtualOffsetAndLineNumber(MeasureFile.LineNumber, MeasureFile.VirtualOffset, MeasureFileArray.Text.StringValue);

            return;
        }
    }
}
