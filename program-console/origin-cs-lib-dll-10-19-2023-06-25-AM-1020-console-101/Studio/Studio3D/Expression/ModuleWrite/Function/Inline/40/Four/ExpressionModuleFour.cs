using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static ExpressionModuleWrite ExpressionModuleFour(ExpressionModuleWrite module)
        {
            var array = ExpressionModuleFunctionFourty.FunctionFlatContainerSurface<Tuple<Int32, Int32, Int32, Int32, String>>(module.Third.Function.TupleArray);

            var function = new ExpressionModuleFunctionFourty(array);

            ExpressionModuleFourth fourth;

            fourth = new ExpressionModuleFourth(function);

            module.Fourth = fourth;

            return module;
        }
    }
}
