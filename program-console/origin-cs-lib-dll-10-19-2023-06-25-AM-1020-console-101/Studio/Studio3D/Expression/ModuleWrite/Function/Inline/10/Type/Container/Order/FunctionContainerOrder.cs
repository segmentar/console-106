using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct ExpressionModuleWrite
    {
        public partial class ExpressionModuleFunctionTen
        {
            public static ArrayList FunctionOrderContainer(Expression[] array_EXPRESSION)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                var ordinal = 1;

                foreach (Expression item_EXPRESSION in array_EXPRESSION)
                {
                    Tuple<Int32, Expression> tuple;

                    tuple = new Tuple<Int32, Expression>(ordinal, item_EXPRESSION);

                    listResult.Add(tuple);

                    ordinal = ordinal + 1;

                    continue;
                }

                return listResult;
            }
        }
    }
}
