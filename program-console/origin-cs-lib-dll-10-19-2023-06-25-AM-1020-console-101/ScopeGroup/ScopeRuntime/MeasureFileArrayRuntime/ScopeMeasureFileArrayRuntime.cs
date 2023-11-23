using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MeasureFileArrayRuntime()
        {
            MeasureFileArray.FileArray = new String[0];

            MeasureFileArray.FilePointer = -1;

            MeasureFileArray.Filename = default(ScopeStringSafe);

            MeasureFileArray.Text = default(ScopeStringSafe);

            return;
        }
    }
}
