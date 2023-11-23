using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class MaterialSymmetryUsageMethod : Attribute
    {
        public MaterialSymmetryUsageMethod()
        {
            return;
        }

        ~MaterialSymmetryUsageMethod()
        {
            return;
        }
    }
}
