using Core;

namespace Core
{
    using System;

    [ScopeIntentionalShortClass]
    public abstract partial class ScopeFatal 
    {
        public String[] InformationArray;

        public Exception Exception;

        public ScopeFatal()
        {
            return;
        }

        ~ScopeFatal()
        {
            return;
        }
    }
}
