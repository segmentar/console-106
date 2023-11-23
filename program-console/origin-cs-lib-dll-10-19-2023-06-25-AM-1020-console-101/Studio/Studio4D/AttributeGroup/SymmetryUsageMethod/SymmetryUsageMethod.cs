using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public class SymmetryUsageMethod : Attribute
    {
        public SymmetryUsageMethod()
        {
            return;
        }

        ~SymmetryUsageMethod()
        {
            return;
        }
    }
}
