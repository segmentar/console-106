using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class MaterialIntentionalShortClass : Attribute
    {
        public MaterialIntentionalShortClass()
        {
            return;
        }

        ~MaterialIntentionalShortClass()
        {
            return;
        }
    }
}
