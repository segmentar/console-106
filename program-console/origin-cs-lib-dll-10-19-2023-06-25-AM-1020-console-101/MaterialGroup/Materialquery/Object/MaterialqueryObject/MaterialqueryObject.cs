using Core;

namespace Core
{
    using System;

    public partial class Materialquery
    {
        public override String ToString()
        {
            return this.ToString(0);
        }

        public String ToString(Int32 Inflect_INTEGER)
        {
            return Data.ToString(Inflect_INTEGER);
        }
    }
}
