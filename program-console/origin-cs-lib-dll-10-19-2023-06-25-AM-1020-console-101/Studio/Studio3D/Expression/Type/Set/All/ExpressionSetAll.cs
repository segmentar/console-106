using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Expression> ExpressionAllSet(Expression expression)
        {
            ICollection<Expression> collectionResult = default;

            collectionResult = new Collection<Expression>();

            collectionResult.Add(expression);

            foreach (Expression expressionChild in expression.ExpressionArrayList)
            {
                var list = ExpressionAllSet(expressionChild);

                foreach (Expression expressionInner in list)
                {
                    collectionResult.Add(expressionInner);

                    continue;
                }

                continue;
            }

            return new List<Expression>(collectionResult);
        }
    }
}
