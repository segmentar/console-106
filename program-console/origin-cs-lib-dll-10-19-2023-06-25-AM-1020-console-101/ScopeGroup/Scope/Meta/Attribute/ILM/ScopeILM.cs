using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class ScopeIntentionalLongMethod : Attribute
    {
        public ScopeIntentionalLongMethod()
        {
            return;
        }

        ~ScopeIntentionalLongMethod()
        {
            return;
        }
    }
}
