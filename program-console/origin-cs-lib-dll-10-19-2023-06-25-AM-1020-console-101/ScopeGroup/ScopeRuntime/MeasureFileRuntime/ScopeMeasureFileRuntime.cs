using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MeasureFileRuntime()
        {
            MeasureFile.PhysicalOffset = -1;

            MeasureFile.RelateOffset = -1;

            MeasureFile.VirtualOffset = -1;

            MeasureFile.LineNumber = -1;

            MeasureFile.Character = default(ScopeCharacterSafe);

            MeasureFile.Line = default(ScopeStringSafe);

            return;
        }
    }
}