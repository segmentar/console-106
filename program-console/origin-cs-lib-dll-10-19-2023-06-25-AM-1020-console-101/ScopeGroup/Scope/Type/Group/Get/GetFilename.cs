using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GetFilename()
        {
            var value = MeasureFileArray.FileArray[MeasureFileArray.FilePointer];

            var safe = ScopeStringSafe.Simple(value);

            MeasureFileArray.Filename = safe;

            return;
        }
    }
}
