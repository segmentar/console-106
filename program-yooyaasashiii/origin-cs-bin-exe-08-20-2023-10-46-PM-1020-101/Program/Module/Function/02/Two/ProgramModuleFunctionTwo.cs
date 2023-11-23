using Core;

namespace Core
{
    using System;

    using System.IO;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionTwo(ProgramModule module)
        {
            DirectoryInfo directoryInfo;

            directoryInfo = module.Program.WorkingDirectory(module.First.CurrentDirectory);

            ProgramModuleFunctionSecond second;

            second = new ProgramModuleFunctionSecond(directoryInfo.FullName);

            module.Second = second;

            return module;
        }
    }
}
