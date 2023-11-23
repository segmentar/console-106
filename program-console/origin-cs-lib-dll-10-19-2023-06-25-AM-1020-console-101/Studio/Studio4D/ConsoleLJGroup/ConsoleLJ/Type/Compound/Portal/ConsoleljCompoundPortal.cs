using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static String ConsoleLJPortalCompound(String[] array_SPLIT, Tuple<String, Object>[] array_PORTAL)
        {
            String stringResult = default;

            var array = ConsoleLJPortalDispenserSurface(array_SPLIT, array_PORTAL);

            var join = String.Join(ConsoleLJPolicy.ConsoleLJCompoundCharacter.ToString(), array);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
