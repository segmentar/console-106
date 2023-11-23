using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Brute(String String_VALUE)
        {
            var expression = new ExpressionSimple(String_VALUE, default(Object)).Result;

            IBrute(expression);

            return;
        }
    }
}
