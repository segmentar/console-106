using Core;

namespace Core
{
    using System;

    public partial interface IExposable<T>
    { 
        T ExposeInstance();

        T CleanInstance();
    }
}
