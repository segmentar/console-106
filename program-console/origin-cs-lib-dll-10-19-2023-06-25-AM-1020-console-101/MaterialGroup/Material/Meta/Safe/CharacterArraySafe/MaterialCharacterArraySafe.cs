using Core;

namespace Core
{
    using System;

    public partial struct MaterialCharacterArraySafe
    {
        public Char[] CharacterArray { get; set; }
        public Char[] CharacterArraySafe { get; set; }

        public static MaterialCharacterArraySafe Simple(Char[] Character_ARRAY)
        {
            MaterialCharacterArraySafe safeResult = default;

            Char[] characterArray;

            characterArray = Character_ARRAY;

            characterArray = Material.SolidCharacterArray(characterArray);

            MaterialCharacterArraySafe safe;

            safe = new MaterialCharacterArraySafe();

            safe.CharacterArray = Character_ARRAY;

            safe.CharacterArraySafe = characterArray;

            safeResult = safe;

            return safeResult;
        }
    }
}
