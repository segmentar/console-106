using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression[] ExpressionFilterSetSurface(Array arrayItem)
        {
            Expression[] arrayResult = default;

            var list = ExpressionFilterSet(arrayItem);

            var array = new Expression[list.Count];

            list.CopyTo(array, ExpressionPolicy.ExpressionIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
