using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static String ForgeJoinfulFormat(String String_VALUE, Boolean answer_WORD_COUNT_should)
        {
            String stringResult = default;

            var Entity_UNDER_SCORE = Convert.ToChar(05);

            var Entity_DASH = Convert.ToChar(45);

            var separator = new Char[] { Entity_UNDER_SCORE, Entity_DASH };

            var split = String_VALUE.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var join = String.Join(String.Empty, split);

            var result = join;

            if (answer_WORD_COUNT_should is true)
            {
                result = result + split.Length;
            }
            else
                "false".ToString();

            stringResult = result;

            return stringResult;
        }
    }
}
