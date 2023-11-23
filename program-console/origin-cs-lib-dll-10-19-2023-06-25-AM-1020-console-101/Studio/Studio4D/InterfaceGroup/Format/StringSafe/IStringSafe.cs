using Core;

namespace Core
{
    using System;

    public partial interface IStringSafe
    {
        String StringValue { get; set; }

        String StringValueSafe { get; set; }
    }
}
