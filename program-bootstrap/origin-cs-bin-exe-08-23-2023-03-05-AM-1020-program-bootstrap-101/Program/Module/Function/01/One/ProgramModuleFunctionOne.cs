using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionOne(ProgramModule module)
        {
            var tuple = Program.ForgeCurrentTuple__FILE_DIRECTORY(false);

            String file, directory, workingDirectory;

            file = tuple.Item1;

            directory = tuple.Item2;

            workingDirectory = Program.ForgeWorkingDirectory(directory, true);

            ProgramModuleFunctionFirst first;

            first = new ProgramModuleFunctionFirst(file, directory, workingDirectory);

            module.First = first;

            return module;
        }
    }
}
