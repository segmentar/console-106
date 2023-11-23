using Core;

namespace Core
{
    using System;

    public partial interface ICharacterSafe
    {
        Char CharacterValue { get; set; }

        Char CharacterValueSafe { get; set; }
    }
}
