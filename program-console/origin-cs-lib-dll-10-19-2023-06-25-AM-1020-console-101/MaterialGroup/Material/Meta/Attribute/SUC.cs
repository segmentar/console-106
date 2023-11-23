using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class MaterialSymmetryUsageClass : Attribute
    {
        public MaterialSymmetryUsageClass()
        {
            return;
        }

        ~MaterialSymmetryUsageClass()
        {
            return;
        }
    }
}
