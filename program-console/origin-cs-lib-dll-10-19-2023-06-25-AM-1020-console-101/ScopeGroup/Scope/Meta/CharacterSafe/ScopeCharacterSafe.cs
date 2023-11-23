using Core;

namespace Core
{
    using System;

    public partial struct ScopeCharacterSafe
    {
        public Char CharacterValue { get; set; }

        public Char CharacterValueSafe { get; set; }

        public static ScopeCharacterSafe Simple(Char Character_VALUE)
        {
            ScopeCharacterSafe safeResult = default;

            var value = Character_VALUE;

            value = Scope.SolidCharacter(Character_VALUE);

            value = Scope.ForgeRepresentCharacter(value);

            Char characterValue, characterValueSafe;

            characterValue = Character_VALUE;

            characterValueSafe = value;

            ScopeCharacterSafe safe;

            safe = new ScopeCharacterSafe();

            safe.CharacterValue = characterValue;

            safe.CharacterValueSafe = characterValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
