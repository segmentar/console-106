using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String ConsoleLJJoinCompound(String[] array_SPLIT)
        {
            String stringResult = default;

            var array = ConsoleLJJoinDispenserSurface(array_SPLIT);

            var join = String.Join(ConsoleLJPolicy.ConsoleLJCompoundCharacter.ToString(), array);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}

