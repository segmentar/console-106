using Core;

namespace Core
{
    using System;

    public partial struct MaterialStringFormat
    {
        public String StringValue { get; set; }

        public String StringValueFormat { get; set; }

        public static MaterialStringFormat Simple(String String_VALUE, params Char[] Character_ARRAY)
        {
            MaterialStringFormat formatResult = default;

            String stringElement;

            stringElement = String_VALUE;

            stringElement = stringElement.Trim(Character_ARRAY);
         
            MaterialStringFormat format;

            format = new MaterialStringFormat();

            format.StringValue = String_VALUE;

            format.StringValueFormat = stringElement;

            formatResult = format;

            return formatResult;
        }
    }
}
