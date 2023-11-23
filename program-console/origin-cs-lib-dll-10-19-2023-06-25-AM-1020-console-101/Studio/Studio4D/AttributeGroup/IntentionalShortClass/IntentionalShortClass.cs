using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class IntentionalShortClass : Attribute
    {
        public IntentionalShortClass()
        {
            return;
        }

        ~IntentionalShortClass()
        {
            return;
        }
    }
}
