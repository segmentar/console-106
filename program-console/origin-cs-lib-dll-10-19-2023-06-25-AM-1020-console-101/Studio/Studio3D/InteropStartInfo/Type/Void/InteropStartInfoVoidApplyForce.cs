using Core;

namespace Core
{
    using System;

    public partial class InteropStartInfo
    {
        public static void InteropStartInfoApplyForceVoid(InteropStartInfo interopStartInfo)
        {
            Boolean hasDefault = true;

            SpecializeConsoleLJ.SetEscapeCharacter(interopStartInfo.EscapeCharacter, hasDefault);

            SpecializeConsoleLJ.SetTerminatorCharacter(interopStartInfo.TerminatorCharacter, hasDefault);

            SpecializeConsoleLJ.SetNativeString(interopStartInfo.NativeString, hasDefault);

            SpecializeConsoleLJ.SetSharedString(interopStartInfo.SharedString, hasDefault);

            return;
        }
    }
}
