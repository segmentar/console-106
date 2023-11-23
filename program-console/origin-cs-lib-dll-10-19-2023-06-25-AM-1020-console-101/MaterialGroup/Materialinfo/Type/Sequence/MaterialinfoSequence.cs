using Core;

namespace Core
{
    using System;

    public partial class MaterialinfoSequence
    {
        public Materialinfo Result { get; set; } = default;

        public MaterialinfoSequence(MaterialStringSafe HeaderSubstring__VALUE, MaterialStringSafe FooterSubstring__VALUE, MaterialCharacterArraySafe EscapeCharacter__ARRAY, Boolean answer_DEBUG_is)
        {
            Debug(HeaderSubstring__VALUE, FooterSubstring__VALUE, EscapeCharacter__ARRAY, answer_DEBUG_is);

            var Entity_PERIOD = Convert.ToChar(46);

            var Entity_WHITE_SPACE = Convert.ToChar(32);

            var separator = new Char[] { Entity_PERIOD, Entity_WHITE_SPACE };

            var split = HeaderSubstring__VALUE.StringValue.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Boolean hasLengthCheck;

            hasLengthCheck = split.Length.Equals(0) is false;

            MaterialStringSafe Namesafe_VALUE;

            if (hasLengthCheck is true)
            {
                var first = split[0];

                Namesafe_VALUE = MaterialStringSafe.Simple(first);
            }
            else
            {
                Namesafe_VALUE = MaterialStringSafe.Simple(String.Empty);
            }

            Materialinfo materialinfo;

            materialinfo = new Materialinfo(Namesafe_VALUE, HeaderSubstring__VALUE, FooterSubstring__VALUE, EscapeCharacter__ARRAY, answer_DEBUG_is);

            this.Result = materialinfo;

            return;
        }

        ~MaterialinfoSequence()
        {
            return;
        }
    }
}
