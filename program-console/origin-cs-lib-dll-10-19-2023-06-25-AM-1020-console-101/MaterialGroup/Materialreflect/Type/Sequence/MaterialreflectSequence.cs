using Core;

namespace Core
{
    using System;
    internal partial class MaterialreflectSequence
    {
        internal Materialreflect Result { get; set; } = default;
        
        internal MaterialreflectSequence(Material Material_VALUE, MaterialStringFormat StringFormat__VALUE, Char[] EscapeCharacter__ARRAY, Boolean answer_DEBUG_is)
        {
            Debug(StringFormat__VALUE, EscapeCharacter__ARRAY, answer_DEBUG_is);

            var InputStringSafe___VALUE = MaterialStringSafe.Simple(StringFormat__VALUE.StringValueFormat);

            var EscapeCharacterArraySafe____VALUE = MaterialCharacterArraySafe.Simple(EscapeCharacter__ARRAY);

            Materialreflect reflect;

            reflect = new Materialreflect(Material_VALUE, InputStringSafe___VALUE, EscapeCharacterArraySafe____VALUE, answer_DEBUG_is);

            this.Result = reflect;

            return;
        }

        ~MaterialreflectSequence()
        {
            return;
        }
    }
}
