using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal Material(MaterialStringSafe headerSubstring, MaterialStringSafe footerSubstring, Boolean answer_DEBUG_is)
        {
            this.HeaderSubstring = headerSubstring;

            this.FooterSubstring = footerSubstring;

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
