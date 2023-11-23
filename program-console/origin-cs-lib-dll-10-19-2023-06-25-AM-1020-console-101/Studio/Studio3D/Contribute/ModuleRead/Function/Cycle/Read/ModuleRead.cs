using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleReadCycle
    {
        public static ContributeModuleRead ModuleRead(ContributeModuleRead module, FileStream item__FILE_STREAM, Boolean answer_RESET_should)
        {
            var array = new Byte[item__FILE_STREAM.Length];

            var read = item__FILE_STREAM.Read(array, 0, array.Length);

            if (answer_RESET_should is true)
            {
                item__FILE_STREAM.Seek(0, SeekOrigin.Begin);
            }
            else
                "false".ToString();

            var function = new FunctionRead(item__FILE_STREAM, array, read);

            module.FunctionRead = function;

            return module;
        }
    }
}
