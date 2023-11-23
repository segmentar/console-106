using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public partial class FunctionFirst
        {
            public FunctionTen Function;

            public FunctionFirst(FunctionTen function)
            {
                this.Function = function;

                return;
            }

            ~FunctionFirst()
            {
                return;
            }
        }
    }
}
