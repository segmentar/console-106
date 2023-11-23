using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public static MaterialreflectPrimarymodule FunctionTwo(MaterialreflectPrimarymodule module)
        {
            var array = FunctionTwenty.FunctionTupleArrayContainerSurface<Tuple<Char, String[]>>(module.Materialreflect.InputString.StringValue, module.Materialreflect.EscapeCharacterArray.CharacterArray);

            var function = new FunctionTwenty(array);

            FunctionSecond second;

            second = new FunctionSecond(function);

            module.Second = second;

            return module;
        }
    }
}
