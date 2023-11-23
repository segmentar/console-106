using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Expression> ExpressionFilterSet(Array arrayItem)
        {
            ICollection<Expression> collectionResult = default;

            collectionResult = new Collection<Expression>();

            foreach (Object objectItem in arrayItem)
            {
                Expression expression;

                expression = objectItem as Expression;

                collectionResult.Add(expression);

                continue;
            }

            return new List<Expression>(collectionResult);
        }
    }
}
