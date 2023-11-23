using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Extf03IL()
        {
            if (ArchitectureOneFirst.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            if (ArchitectureOneFirst.HasLinger)
            {
                ArchitectureOneFirst.IsExternalCall = false;
            }
            else
            {
                ArchitectureOneFirst.IsExternalCall = true;
            }

            return;
        }
    }
}
