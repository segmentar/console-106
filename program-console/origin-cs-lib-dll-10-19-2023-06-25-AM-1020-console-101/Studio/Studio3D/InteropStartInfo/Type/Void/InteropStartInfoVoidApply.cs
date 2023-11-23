using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class InteropStartInfo
    {
        public static void InteropStartInfoApplyVoid(InteropStartInfo interopStartInfo)
        {
            Boolean hasDefault = true;

            if (ArchitectureConsoleLJOneFirst.HasEscapeCharacter is false)
            {
                SpecializeConsoleLJ.SetEscapeCharacter(interopStartInfo.EscapeCharacter, hasDefault);
            }
            else
                "false".ToString();

            if (ArchitectureConsoleLJOneFirst.HasTerminatorCharacter is false)
            {
                SpecializeConsoleLJ.SetTerminatorCharacter(interopStartInfo.TerminatorCharacter, hasDefault);
            }
            else
                "false".ToString();

            if (ArchitectureConsoleLJOneFirst.HasNativeString is false)
            {
                SpecializeConsoleLJ.SetNativeString(interopStartInfo.NativeString, hasDefault);
            }
            else
                "false".ToString();

            if (ArchitectureConsoleLJOneFirst.HasSharedString is false)
            {
                SpecializeConsoleLJ.SetSharedString(interopStartInfo.SharedString, hasDefault);
            }
            else
                "false".ToString();

            return;
        }
    }
}
