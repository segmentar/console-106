using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static MaterialModule ModuleTwo(MaterialModule module)
        {
            var array = FunctionPeriodFilterContainerSurface<Tuple<Int32, String>>(module.First.Function.TupleArray, 2);

            var function = new FunctionTwenty(array);

            FunctionSecond second;

            second = new FunctionSecond(function);

            module.Second = second;

            return module;
        }
    }
}
