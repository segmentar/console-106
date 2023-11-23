using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static ExpressionModuleWrite ExpressionModuleOne(ExpressionModuleWrite module)
        {
            var array = ExpressionModuleFunctionTen.FunctionOrderContainerSurface<Tuple<Int32, Expression>>(module.ExpressionArray);

            var function = new ExpressionModuleFunctionTen(array);

            ExpressionModuleFirst first;

            first = new ExpressionModuleFirst(function);

            module.First = first;

            return module;
        }
    }
}
