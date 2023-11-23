using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void VOperation(String Filename_VALUE, Stack value_STACK, String[] Parameter_ARRAY, String[] Split_ARRAY, String[] SplitTruncate__ARRAY, String Lower_VALUE)
        {
            IView(this);

            IOperation(Filename_VALUE, value_STACK, Parameter_ARRAY, Split_ARRAY, SplitTruncate__ARRAY, Lower_VALUE);

            return;
        }
    }
}
