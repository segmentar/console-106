using Core;

namespace Core
{
    using System;

    public partial struct MaterialCharacterSafe
    {
        public Char CharacterValue { get; set; }

        public Char CharacterValueSafe { get; set; }

        public static MaterialCharacterSafe Simple(Char Character_VALUE)
        {
            MaterialCharacterSafe safeResult = default;

            Char character;

            character = Character_VALUE;

            character = Material.SolidCharacter(character);

            character = Material.RepresentCharacter(character);

            Char characterValue, characterValueSafe;

            characterValue = Character_VALUE;

            characterValueSafe = character;

            MaterialCharacterSafe safe;

            safe = new MaterialCharacterSafe();

            safe.CharacterValue = characterValue;

            safe.CharacterValueSafe = characterValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
