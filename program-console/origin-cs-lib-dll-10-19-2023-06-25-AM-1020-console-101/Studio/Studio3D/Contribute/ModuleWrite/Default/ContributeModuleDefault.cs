using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWrite
    {
        public static ContributeModuleWrite ContributeModuleDefault(Contribute[] array_CONTRIBUTE)
        {
            ContributeModuleWrite module;

            module = new ContributeModuleWrite();

            try
            {
                module = ContributeModuleWriteCycle.ModuleWrite(module, array_CONTRIBUTE);

                module = ContributeModuleWriteInline.ContributeModuleOne(module, module.FunctionWrite.ContributeArray);

                module = ContributeModuleWriteInline.ContributeModuleTwo(module, module.First.Function.TupleArray);

                module = ContributeModuleWriteInline.ContributeModuleThree(module, module.Second.Function.TupleArray);

                module = ContributeModuleWriteCycle.ModuleHeader
(
module,
module.Third.Function.TupleArrayA,
module.Third.Function.TupleArrayB,
module.Third.Function.TupleArrayC,
module.Third.Function.TupleArrayD,
module.FunctionWrite.Length
);

                module = ContributeModuleWriteLone.ModuleAA(module, module.FunctionHeader.ObjectIdentityTableAddress);

                module = ContributeModuleWriteLone.ModuleMemoryStreamA(module, module.Third.Function.TupleArrayA);

                module = ContributeModuleWriteLone.ModuleMemoryStreamB(module, module.Third.Function.TupleArrayB, module.FunctionHeader.ObjectIdentityTableAddress);

                module = ContributeModuleWriteLone.ModuleMemoryStreamC(module, module.Third.Function.TupleArrayC, module.FunctionHeader.ObjectIdentityTableAddress);

                module = ContributeModuleWriteLone.ModuleMemoryStreamD(module, module.Third.Function.TupleArrayD, module.FunctionHeader.ObjectIdentityTableAddress);
                
                module = ContributeModuleWriteLone.ModuleObjectIdentityMemoryStream(module);

                module = ContributeModuleWriteLone.ModuleHeaderMemoryStream(module);       
                
                module = ContributeModuleWriteLone.ModuleMemoryStream(module);

                module = ContributeModuleWriteInline.ContributeModuleFour(module);
            }
            catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return module;
        }
    }
}
