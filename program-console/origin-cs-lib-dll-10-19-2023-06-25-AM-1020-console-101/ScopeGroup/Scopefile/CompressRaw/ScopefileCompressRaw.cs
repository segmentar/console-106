using Core;

namespace Core
{
    using System;

    public partial class Scopefile
    {
        public ScopeStringSafe Filename;

        public ScopeStringArraySafe LocalLineArray;

        public ScopeStringArraySafe GlobalLineArray;

        internal Material[] ElementArray;
    }
}
