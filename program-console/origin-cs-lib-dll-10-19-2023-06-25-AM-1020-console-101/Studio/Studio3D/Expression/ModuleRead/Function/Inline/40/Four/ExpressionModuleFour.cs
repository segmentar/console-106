using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        public static ExpressionModuleRead ExpressionModuleFour(ExpressionModuleRead module)
        {
            var array = ExpressionModuleFunctionFourty.FunctionExpressionContainerSurface<Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression>>(module.Third.Function.TupleArray);

            var function = new ExpressionModuleFunctionFourty(array);

            ExpressionModuleFourth fourth;

            fourth = new ExpressionModuleFourth(function);

            module.Fourth = fourth;

            return module;
        }
    }
}
