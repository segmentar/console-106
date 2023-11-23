using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static ExpressionModuleWrite ExpressionModuleTwo(ExpressionModuleWrite module)
        {
            var array = ExpressionModuleFunctionTwenty.FunctionRelateContainerSurface<Tuple<Int32, Int32, Expression>>(module.First.Function.TupleArray);

            var function = new ExpressionModuleFunctionTwenty(array);

            ExpressionModuleSecond second;

            second = new ExpressionModuleSecond(function);

            module.Second = second;

            return module;
        }
    }
}
