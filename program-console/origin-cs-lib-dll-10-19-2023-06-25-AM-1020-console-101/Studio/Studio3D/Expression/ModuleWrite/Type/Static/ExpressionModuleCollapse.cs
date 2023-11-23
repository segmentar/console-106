using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static Byte[] Collapse(Expression item_EXPRESSION, Boolean answer_CLOSE_should, Boolean answer_POLICY_is)
        {
            Byte[] arrayResult = default;

            ExpressionModuleWrite expressionModule = ExpressionModuleAction(item_EXPRESSION, answer_POLICY_is);

            var array = expressionModule.MemoryStream.ToArray();

            if (answer_CLOSE_should is true)
            {
                Close(expressionModule);
            }
            else
                "false".ToString();

            arrayResult = array;
            
            return arrayResult;
        }
    }
}
