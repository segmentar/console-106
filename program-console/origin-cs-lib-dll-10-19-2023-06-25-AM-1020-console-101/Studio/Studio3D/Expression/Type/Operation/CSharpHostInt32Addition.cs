using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static void CSharpHostInt32Addition(Expression item_EXPRESSION, String[] array_STRING)
        {
            Expression left, right, result;

            left = (Expression)(item_EXPRESSION.UPeek(array_STRING[0]).ExpressionArrayList[0] as Object);

            right = (Expression)(item_EXPRESSION.UPeek(array_STRING[1]).ExpressionArrayList[0] as Object);

            result = item_EXPRESSION.UPeek(array_STRING[2]);

            Int32 leftInteger, rightInteger, answerInteger;

            leftInteger = (Int32)(left.ObjectIdentity as Object);

            rightInteger = (Int32)(right.ObjectIdentity as Object);

            answerInteger = (leftInteger + rightInteger);

            result.ObjectIdentity = answerInteger;

            return;
        }
    }
}
