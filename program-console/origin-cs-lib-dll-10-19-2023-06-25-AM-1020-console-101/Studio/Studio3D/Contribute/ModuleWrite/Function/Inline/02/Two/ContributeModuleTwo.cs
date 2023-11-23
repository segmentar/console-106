using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteInline
    {
        public static ContributeModuleWrite ContributeModuleTwo(ContributeModuleWrite module, Tuple<Int32, Contribute>[] array_TUPLE)
        {
            var array = ModuleTwenty.FunctionRegionContainerSurface<Tuple<Int32, Int32, Int32, Contribute>>(array_TUPLE);

            var function = new ModuleTwenty(array);

            ContributeModuleSecond second;

            second = new ContributeModuleSecond(function);

            module.Second = second;

            return module;
        }
    }
}
