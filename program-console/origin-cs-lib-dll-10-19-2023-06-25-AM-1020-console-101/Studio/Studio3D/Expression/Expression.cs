using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public static ArrayList ViewList = new ArrayList();

        public static ArrayList BindList = new ArrayList();

        public static Expression LastLock = default(Expression);

        public Expression()
        {
            return;
        }

        ~Expression()
        {
            return;
        }
    }
}
