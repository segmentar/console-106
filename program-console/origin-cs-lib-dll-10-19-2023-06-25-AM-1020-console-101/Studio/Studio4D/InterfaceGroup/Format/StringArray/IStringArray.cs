using Core;

namespace Core
{
    using System;

    public partial interface IStringArray
    {
        String[] StringArray { get; set; }

        String[] StringArraySafe { get; set; }
    }
}
