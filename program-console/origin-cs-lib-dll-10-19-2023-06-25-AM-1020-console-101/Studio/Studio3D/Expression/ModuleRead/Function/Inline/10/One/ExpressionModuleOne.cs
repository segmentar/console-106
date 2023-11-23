using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        public static ExpressionModuleRead ExpressionModuleOne(ExpressionModuleRead module)
        {
            var tuple = ExpressionModuleFunctionTen.ForgeAddressTable(module.FileStream);

            var function = new ExpressionModuleFunctionTen(tuple);

            ExpressionModuleFirst first;

            first = new ExpressionModuleFirst(function);

            module.First = first;

            return module;
        }
    }
}
