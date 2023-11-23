using Core;

namespace Core
{
    using System;

    public partial class ExpressionSimple
    {
        public Expression Result { get; set; } = default;

        public ExpressionSimple()
        {
            return;
        }

        ~ExpressionSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Collections;

    public partial class ExpressionSimple
    {
        public ExpressionSimple(String stringIdentity, Object objectIdentity, params Object[] objectArray)
        {
            var boolean_match_DEFAULT_is = false;

            boolean_match_DEFAULT_is = false;

            boolean_match_DEFAULT_is = boolean_match_DEFAULT_is || (objectArray == null) is true;

            boolean_match_DEFAULT_is = boolean_match_DEFAULT_is || (objectArray == default) is true;

            Boolean isDefaultCheck;

            isDefaultCheck = boolean_match_DEFAULT_is is true;

            if (isDefaultCheck is true)
            {
                var array_OBJECT = new Object[0];

                objectArray = array_OBJECT;
            }
            else
                "false".ToString();

            ArrayList arrayList;

            arrayList = new ArrayList(Expression.ExpressionChildSetSurface(objectArray));

            Expression expression;

            expression = Expression.MakeExpressionDefaultSurface(stringIdentity, objectIdentity, arrayList);

            this.Result = expression;

            return;
        }
    }
}
