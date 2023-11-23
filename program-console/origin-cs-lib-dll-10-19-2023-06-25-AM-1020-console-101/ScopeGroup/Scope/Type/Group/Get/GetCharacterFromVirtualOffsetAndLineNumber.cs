using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static ScopeCharacterSafe GetCharacterFromVirtualOffsetAndLineNumber(Int32 LineNumber__ITEM, Int32 VirtualOffset__ITEM, String Text_ITEM)
        {
            ScopeCharacterSafe safeResult = default;

            var position = GetPhysicalOffsetFromVirtualOffsetAndLineNumber(LineNumber__ITEM, VirtualOffset__ITEM, Text_ITEM);

            var character = Text_ITEM[position];

            var safe = ScopeCharacterSafe.Simple(character);

            safeResult = safe;

            return safeResult;
        }
    }
}
