using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public partial interface IScopeExposable<T>
        {
            T ExposeInstance();

            T CleanInstance();
        }
    }
}
