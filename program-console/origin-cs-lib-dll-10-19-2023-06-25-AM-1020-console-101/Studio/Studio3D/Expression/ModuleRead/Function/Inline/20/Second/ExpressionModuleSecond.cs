using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleSecond
        {
            public ExpressionModuleFunctionTwenty Function;

            public ExpressionModuleSecond(ExpressionModuleFunctionTwenty function)
            {
                this.Function = function;

                return;
            }

            ~ExpressionModuleSecond()
            {
                return;
            }
        }
    }
}
