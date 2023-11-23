using Core;

namespace Core
{
    using System;

    public partial class Scopefile
    {
        public static Scopefile MakeScopeFileDefaultSurface()
        {
            Scopefile scopefileResult = default;

            scopefileResult = MakeScopeFileDefault(ScopefilePolicy.ScopefileDebugPolicy);

            return scopefileResult;
        }
    }
}
