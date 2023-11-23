using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Object> ExpressionObjectSet(Expression[] array_EXPRESSION)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new Collection<Object>();

            foreach (Expression item_EXPRESSION in array_EXPRESSION)
            {
                collectionResult.Add(item_EXPRESSION.ObjectIdentity);

                continue;
            }

            return new List<Object>(collectionResult);
        }
    }
}
