using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public partial class FunctionThird
        {
            public FunctionThirty Function;

            public FunctionThird(FunctionThirty function)
            {
                this.Function = function;

                return;
            }

            ~FunctionThird()
            {
                return;
            }
        }
    }
}
