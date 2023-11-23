using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleDefault()
        {
            Program program;

            program = Program.MakeProgramDefaultSurface();

            if (ArchitectureOneFirst.IsExternalCall is false)
            {
                Specialize.SetNativeString("::", true);

                program.SettingSetup();

                program.ConsoleSetup();
            }
            else
                "false".ToString();

            ProgramModule module;

            module = new ProgramModule();

            module.Program = program;

            module = ProgramModuleFunctionOne(module);

            return module;
        }
    }
}
