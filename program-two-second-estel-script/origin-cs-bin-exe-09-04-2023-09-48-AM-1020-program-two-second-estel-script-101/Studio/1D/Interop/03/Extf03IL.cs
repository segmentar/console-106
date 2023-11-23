using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Extf03IL()
        {
            if (ArchitecturePageOneFirst.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            if (ArchitecturePageOneFirst.HasLinger)
            {
                ArchitecturePageOneFirst.IsExternalCall = false;
            }
            else
            {
                ArchitecturePageOneFirst.IsExternalCall = true;
            }

            return;
        }
    }
}
