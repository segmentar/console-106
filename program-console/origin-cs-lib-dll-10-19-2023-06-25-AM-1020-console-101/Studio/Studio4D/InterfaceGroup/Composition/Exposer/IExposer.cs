using Core;

namespace Core
{
    using System;

    public partial interface IExposer
    { 
        void ExposeReferencePage();

        void CleanReferencePage();
    }
}
