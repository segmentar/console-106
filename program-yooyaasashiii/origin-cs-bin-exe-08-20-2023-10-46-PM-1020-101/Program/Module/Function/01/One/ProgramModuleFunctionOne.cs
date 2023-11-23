using Core;

namespace Core
{
    using System;

    internal partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleFunctionOne(ProgramModule module)
        {
            var tuple = module.Program.CurrentFileDirectoryTuple();

            ProgramModuleFunctionFirst first;

            first = new ProgramModuleFunctionFirst(tuple.Item1, tuple.Item2);

            module.First = first;

            return module;
        }
    }
}
