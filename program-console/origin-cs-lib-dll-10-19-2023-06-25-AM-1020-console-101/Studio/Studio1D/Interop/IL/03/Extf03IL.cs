using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Extf03IL()
        {
            if (InteropArchitecture.HasLength is false)
            {
                return;
            }
            else
                "false".ToString();

            if (InteropArchitecture.HasLinger)
            {
                InteropArchitecture.IsExternalCall = false;
            }
            else
            {
                InteropArchitecture.IsExternalCall = true;
            }

            return;
        }
    }
}
