using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryMeasure
    {
        [MaterialIntentionalShortMethod]
        public String ToString(Int32 Inflect_INTEGER)
        {
            return ForgeInflectRepresentation(Inflect_INTEGER);
        }
    }
}
