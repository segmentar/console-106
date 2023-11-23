using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public partial interface IScopeExposer
        {
            void ExposeReferencePage();

            void CleanReferencePage();
        }
    }
}
