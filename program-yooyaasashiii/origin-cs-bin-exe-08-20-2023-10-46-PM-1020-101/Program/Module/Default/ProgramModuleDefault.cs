using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleDefault()
        {
            ProgramModule module;

            module = new ProgramModule();

            module.Program = Program.MakeProgramDefaultSurface();

            module.Program.SetupConsole();

            module = ProgramModuleFunctionOne(module);

            module = ProgramModuleFunctionTwo(module);

            Program.ProgramBuildVoid(module.Second.WorkingDirectory);

            return module;
        }
    }
}
