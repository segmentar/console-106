using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Object[] ExpressionObjectSetSurface(Expression[] array_EXPRESSION)
        {
            Object[] arrayResult = default;

            var list = ExpressionObjectSet(array_EXPRESSION);

            var array = new Object[list.Count];

            list.CopyTo(array, ExpressionPolicy.ExpressionIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
