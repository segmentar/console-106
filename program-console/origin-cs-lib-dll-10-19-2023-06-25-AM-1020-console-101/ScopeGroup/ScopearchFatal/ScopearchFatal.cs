using Core;

namespace Core
{
    using System;

    [ScopeIntentionalShortClass]
    public abstract partial class ScopearchFatal 
    {
        public String[] InformationArray;

        public Exception Exception;

        public ScopearchFatal()
        {
            return;
        }

        ~ScopearchFatal()
        {
            return;
        }
    }
}
