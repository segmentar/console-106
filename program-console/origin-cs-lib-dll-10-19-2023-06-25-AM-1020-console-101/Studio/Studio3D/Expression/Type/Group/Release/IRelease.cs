using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression[] IRelease()
        {
            Expression[] arrayResult = default;

            var array = new Expression[ViewList.Count];

            ViewList.CopyTo(array, ExpressionPolicy.ExpressionIndexPolicy);

            ViewList.Clear();

            arrayResult = array;

            return arrayResult;
        }
    }
}