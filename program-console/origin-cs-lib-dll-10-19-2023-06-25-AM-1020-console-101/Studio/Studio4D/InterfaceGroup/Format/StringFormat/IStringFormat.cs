using Core;

namespace Core
{
    using System;

    public partial interface IStringFormat
    {
        String StringValue { get; set; }

        String StringValueFormat { get; set; }
    }
}
