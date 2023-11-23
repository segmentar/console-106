using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteInline
    {
        public static ContributeModuleWrite ContributeModuleFour(ContributeModuleWrite module)
        {
            var array = module.Streamline.MemoryStream.ToArray();

            var function = new ContributeModuleFourty(array);

            ContributeModuleFourth fourth;

            fourth = new ContributeModuleFourth(function);

            module.Fourth = fourth;

            return module;
        }
    }
}
