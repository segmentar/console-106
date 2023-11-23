using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Byte[][] ExpressionReflectSetSurface(Object[] array_OBJECT)
        {
            Byte[][] jaggedResult = default;

            var list = ExpressionReflectSet(array_OBJECT);

            var array = new Byte[list.Count][];

            list.CopyTo(array, ExpressionPolicy.ExpressionIndexPolicy);

            jaggedResult = array;

            return jaggedResult;
        }
    }
}
