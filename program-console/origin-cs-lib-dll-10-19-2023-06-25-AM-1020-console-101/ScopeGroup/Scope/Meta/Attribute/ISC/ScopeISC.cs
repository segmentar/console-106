using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class ScopeIntentionalShortClass : Attribute
    {
        public ScopeIntentionalShortClass()
        {
            return;
        }

        ~ScopeIntentionalShortClass()
        {
            return;
        }
    }
}
