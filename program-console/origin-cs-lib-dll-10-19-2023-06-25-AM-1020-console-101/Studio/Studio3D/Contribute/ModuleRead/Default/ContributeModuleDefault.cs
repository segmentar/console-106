using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleRead
    {
        public static ContributeModuleRead ContributeModuleDefault(FileStream item__FILE_STREAM)
        {
            ContributeModuleRead module;

            module = new ContributeModuleRead();

            try
            {
                module = ContributeModuleReadCycle.ModuleRead(module, item__FILE_STREAM, true);

                module = ContributeModuleReadCycle.ModuleHeader(module, item__FILE_STREAM);

                module = ContributeModuleReadCycle.ModuleA(module, module.FunctionHeader.TabulationTableLengthA, module.FunctionHeader.TabulationTableAddressA);

                module = ContributeModuleReadCycle.ModuleAA(module, module.FunctionArrayA);

                module = ContributeModuleReadInline.FunctionOne
(
module,
module.FunctionAA.ContributeArray,
new Contribute[0],
new Contribute[0],
new Contribute[0]
);

            } catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return module;
        }
    }
}
