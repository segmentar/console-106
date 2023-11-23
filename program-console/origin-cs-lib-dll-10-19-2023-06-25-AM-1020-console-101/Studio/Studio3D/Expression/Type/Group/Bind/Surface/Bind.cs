using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Bind(Object item_OBJECT)
        {
            var list = IMod();

            Expression currentExpression;

            currentExpression = list.Last.Value;

            Expression expression;

            expression = IBind(currentExpression, item_OBJECT);

            BindList.Add(expression);

            return;
        }
    }
}
