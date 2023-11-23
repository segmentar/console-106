using Core;

namespace Core
{
    using System;

    internal partial class Materialreflect
    {
        internal Materialreflect(Material material, MaterialStringSafe inputString, MaterialCharacterArraySafe escapeCharacterArray, Boolean answer_DEBUG_is)
        {
            this.Material = material;

            this.InputString = inputString;

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
