using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteInline
    {
        public static ContributeModuleWrite ContributeModuleOne(ContributeModuleWrite module, Contribute[] array_CONTRIBUTE)
        {
            var array = ModuleTen.ContributeOrderContainerSurface<Tuple<Int32, Contribute>>(array_CONTRIBUTE);

            var function = new ModuleTen(array);

            ContributeModuleFirst first;

            first = new ContributeModuleFirst(function);

            module.First = first;

            return module;
        }
    }
}
