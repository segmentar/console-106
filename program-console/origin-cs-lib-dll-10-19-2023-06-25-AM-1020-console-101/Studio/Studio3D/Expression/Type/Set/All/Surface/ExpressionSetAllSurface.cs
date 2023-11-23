using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Expression[] ExpressionAllSetSurface(Expression expression)
        {
            Expression[] arrayResult = default;

            var list = ExpressionAllSet(expression);

            var array = new Expression[list.Count];

            list.CopyTo(array, ExpressionPolicy.ExpressionIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
