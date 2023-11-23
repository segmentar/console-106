using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class ScopeIntentionalLongClass : Attribute
    {
        public ScopeIntentionalLongClass()
        {
            return;
        }

        ~ScopeIntentionalLongClass()
        {
            return;
        }
    }
}
