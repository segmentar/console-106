using Core;

namespace Core
{
    using System;
    
    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFirst
        {
            public ExpressionModuleFunctionTen Function;

            public ExpressionModuleFirst(ExpressionModuleFunctionTen function)
            {
                this.Function = function;

                return;
            }

            ~ExpressionModuleFirst()
            {
                return;
            }
        }
    }
}
