using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetCharacter()
        {
            MeasureFile.Character = ScopeCharacterSafe.Simple(MeasureFileArray.Text.StringValue[MeasureFile.PhysicalOffset]);
        }
    }
}
