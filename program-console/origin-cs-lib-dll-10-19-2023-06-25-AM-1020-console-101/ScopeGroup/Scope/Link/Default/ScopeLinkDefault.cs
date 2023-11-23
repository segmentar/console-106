using Core;

namespace Core
{
    using System;

    public partial class ScopeDefault
    {
        public static readonly String MaterialStringStartDefault;

        public static readonly String MaterialStringEndDefault;

        static ScopeDefault()
        {
            var Entity_PERIOD = Convert.ToChar(46);

            MaterialStringStartDefault = Entity_PERIOD.ToString();

            MaterialStringEndDefault = new String(Entity_PERIOD, 5);

            return;
        }
    }
}
