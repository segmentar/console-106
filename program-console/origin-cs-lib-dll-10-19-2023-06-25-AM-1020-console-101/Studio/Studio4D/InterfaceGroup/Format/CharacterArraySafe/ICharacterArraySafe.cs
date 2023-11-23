using Core;

namespace Core
{
    using System;

    public partial interface ICharacterArraySafe
    {
        Char[] CharacterArray { get; set; }

        Char[] CharacterArraySafe { get; set; }
    }
}
