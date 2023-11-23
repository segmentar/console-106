using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static ExpressionModuleWrite ExpressionModuleThree(ExpressionModuleWrite module)
        {
            var array = ExpressionModuleFunctionThirty.FunctionRegionContainerSurface<Tuple<Int32, Int32, Int32, Int32, Expression>>(module.Second.Function.TupleArray, module.IdentityObjectStartAddressArray, module.IdentityObjectEndAddressArray, module.ExpressionLength);

            var function = new ExpressionModuleFunctionThirty(array);

            ExpressionModuleThird third;

            third = new ExpressionModuleThird(function);

            module.Third = third;

            return module;
        }
    }
}
