using Core;

namespace Core
{
    using System;

    public partial class Scopefile
    {
        public Scopefile(ScopeStringSafe filename, ScopeStringArraySafe localLineArray, ScopeStringArraySafe globalLineArray, Boolean debug)
        {
            this.Filename = filename;

            this.LocalLineArray = localLineArray;

            this.GlobalLineArray = globalLineArray;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
