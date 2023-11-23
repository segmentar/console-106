using Core;

namespace Core
{ 
    public partial struct ExpressionModuleWrite
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
