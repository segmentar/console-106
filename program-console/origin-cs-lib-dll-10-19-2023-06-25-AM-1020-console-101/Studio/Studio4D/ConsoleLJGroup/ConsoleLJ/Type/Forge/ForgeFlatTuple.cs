using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String[], String, Int32, Boolean> ForgeFlatTuple(String item_TEXT)
        {
            Tuple<String[], String, Int32, Boolean> tupleResult = default;

            Boolean hasLengthCheck;

            hasLengthCheck = item_TEXT.Equals(String.Empty) is false;

            var lower = item_TEXT.ToLower();

            var whitespace = Convert.ToChar(32);

            var split = item_TEXT.Split(new String[] { whitespace.ToString() }, StringSplitOptions.None);

            var length = split.Length;

            Tuple<String[], String, Int32, Boolean> tuple;

            tuple = new Tuple<String[], String, Int32, Boolean>(split, lower, length, hasLengthCheck);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
