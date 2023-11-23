using Core;

namespace Core
{
    using System;

    public partial struct MaterialStringSplitcharacter
    {
        public String StringValue { get; set; }

        public String StringValueSplit { get; set; }

        public static MaterialStringSplitcharacter Simple(String String_VALUE, params Char[] Character_ARRAY)
        {
            MaterialStringSplitcharacter splitcharacterResult = default;
            
            var split = String_VALUE.Split(Character_ARRAY, StringSplitOptions.None);

            var Entity_WHITE_SPACE = Convert.ToChar(32);

            var join = String.Join(Entity_WHITE_SPACE.ToString(), split);

            MaterialStringSplitcharacter splitcharacter;

            splitcharacter = new MaterialStringSplitcharacter();

            splitcharacter.StringValue = String_VALUE;

            splitcharacter.StringValueSplit = join;

            splitcharacterResult = splitcharacter;

            return splitcharacterResult;
        }
    }
}
