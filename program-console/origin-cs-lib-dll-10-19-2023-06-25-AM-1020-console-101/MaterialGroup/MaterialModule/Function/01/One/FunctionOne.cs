using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static MaterialModule ModuleOne(MaterialModule module)
        {
            var array = FunctionPeriodContainerSurface<Tuple<Int32, String>>(module.Material.HeaderSubstring.StringValue);

            var function = new FunctionTen(array);

            FunctionFirst first;

            first = new FunctionFirst(function);

            module.First = first;

            return module;
        }
    }
}
