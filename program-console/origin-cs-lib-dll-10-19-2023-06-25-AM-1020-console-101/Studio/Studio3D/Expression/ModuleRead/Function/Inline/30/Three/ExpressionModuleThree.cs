using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        public static ExpressionModuleRead ExpressionModuleThree(ExpressionModuleRead module)
        {
            var array = ExpressionModuleFunctionThirty.FunctionRegionContainerSurface<Tuple<Int32, Int32, Int32, Int32, String, Byte[]>>(module.FileStream, module.Second.Function.TupleArray);

            var function = new ExpressionModuleFunctionThirty(array);

            ExpressionModuleThird third;

            third = new ExpressionModuleThird(function);

            module.Third = third;

            return module;
        }
    }
}
