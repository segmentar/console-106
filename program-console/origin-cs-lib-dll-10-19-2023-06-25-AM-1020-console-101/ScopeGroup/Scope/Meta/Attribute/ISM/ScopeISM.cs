using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class ScopeIntentionalShortMethod : Attribute
    {
        public ScopeIntentionalShortMethod()
        {
            return;
        }

        ~ScopeIntentionalShortMethod()
        {
            return;
        }
    }
}
