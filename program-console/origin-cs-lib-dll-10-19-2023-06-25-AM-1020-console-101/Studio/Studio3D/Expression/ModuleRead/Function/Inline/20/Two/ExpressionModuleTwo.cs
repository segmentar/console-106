using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        public static ExpressionModuleRead ExpressionModuleTwo(ExpressionModuleRead module)
        {
            var array = ExpressionModuleFunctionTwenty.FunctionStringIdentityContainerSurface<Tuple<Int32, Int32, Int32, Int32, String>>(module.FileStream, module.First.Function.Tuple);

            var function = new ExpressionModuleFunctionTwenty(array);

            ExpressionModuleSecond second;

            second = new ExpressionModuleSecond(function);

            module.Second = second;

            return module;
        }
    }
}
