using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void InstructionHandler(String Filename_VALUE, String[] LocalLine__ARRAY)
        {
            ExpressionInstructionHandlerPartZeroTen(Filename_VALUE, LocalLine__ARRAY);

            Render($"{ExpressionCode.RenderPath.Core_Expression}-{nameof(Expression)}", this);

            return;
        }
    }
}
