using Core;

namespace Core
{
    using System;

    public partial class Materialinfo
    {
        public Materialinfo(MaterialStringSafe name, MaterialStringSafe headerSubstring, MaterialStringSafe footerSubstring, MaterialCharacterArraySafe escapeCharacterArray, Boolean answer_DEBUG_is)
        {
            this.Name = name;

            this.HeaderSubstring = headerSubstring;

            this.FooterSubstring = footerSubstring;

            this.EscapeCharacterArray = escapeCharacterArray;

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
