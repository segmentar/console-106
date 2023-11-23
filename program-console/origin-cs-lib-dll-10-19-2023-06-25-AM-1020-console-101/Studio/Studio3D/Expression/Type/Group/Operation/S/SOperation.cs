using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void SOperation(String Filename_VALUE, Stack value_STACK, String[] Parameter_ARRAY, String[] Split_ARRAY, String[] SplitTruncate__ARRAY, String Lower_VALUE)
        {
            var last = IModLast();

            foreach (String Parameter_VALUE in Parameter_ARRAY)
            {
                ULock(Parameter_VALUE);

                IView(last);

                continue;
            }

            IView(last);

            IOperation(Filename_VALUE, value_STACK, Parameter_ARRAY, Split_ARRAY, SplitTruncate__ARRAY, Lower_VALUE);

            return;
        }
    }
}
