using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static MaterialModule ModuleThree(MaterialModule module)
        {
            var array = FunctionPeriodCompoundSurface(module.Second.Function.TupleArray);

            var function = new FunctionThirty(array);

            FunctionThird third;

            third = new FunctionThird(function);

            module.Third = third;

            return module;
        }
    }
}
