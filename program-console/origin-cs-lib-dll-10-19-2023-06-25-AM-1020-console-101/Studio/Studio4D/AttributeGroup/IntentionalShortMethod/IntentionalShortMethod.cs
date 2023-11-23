using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class IntentionalShortMethod : Attribute
    {
        public IntentionalShortMethod()
        {
            return;
        }

        ~IntentionalShortMethod()
        {
            return;
        }
    }
}
