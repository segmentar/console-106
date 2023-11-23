using Core;

namespace Core
{
    using System;

    public partial class Materialchain
    {
        public Materialchain(Materialinfo materialinfo, Materialquery[] materialqueryArray, Materialquery[] materialqueryIsolateArray)
        {
            this.Materialinfo = materialinfo;

            this.MaterialqueryArray = materialqueryArray;

            this.MaterialqueryIsolateArray = materialqueryIsolateArray;

            return;
        }
    }
}
