using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteCycle
    {
        public static ContributeModuleWrite ModuleWrite(ContributeModuleWrite module, Contribute[] array_CONTRIBUTE)
        {
            var aoth = array_CONTRIBUTE.Length;

            var function = new FunctionWrite(array_CONTRIBUTE, aoth);

            module.FunctionWrite = function;

            return module;
        }
    }
}
