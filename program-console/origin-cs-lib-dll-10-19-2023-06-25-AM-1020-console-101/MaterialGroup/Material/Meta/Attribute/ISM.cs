using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class MaterialIntentionalShortMethod : Attribute
    {
        public MaterialIntentionalShortMethod()
        {
            return;
        }

        ~MaterialIntentionalShortMethod()
        {
            return;
        }
    }
}
