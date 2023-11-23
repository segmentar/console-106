using Core;

namespace Core
{
    using System;

    public static partial class ScopeImmutable
    {
        public static readonly String MaterialStringStart;

        public static readonly String MaterialStringEnd;

        static ScopeImmutable()
        {
            MaterialStringStart = ScopeDefault.MaterialStringStartDefault;

            MaterialStringEnd = ScopeDefault.MaterialStringEndDefault;

            return;
        }
    }
}
