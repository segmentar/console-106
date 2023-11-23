using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void HVOperation(String Filename_VALUE, Stack value_STACK, String[] Parameter_ARRAY, String[] Split_ARRAY, String[] SplitTruncate__ARRAY)
        {
            try
            {
                Boolean hasLengthCheck, isFatalCheck;

                hasLengthCheck = SplitTruncate__ARRAY.Length.Equals(1) is true;

                isFatalCheck = hasLengthCheck is false;

                if (isFatalCheck is true)
                {
                    var information = new String[] {

                        String.Empty + nameof(hasLengthCheck) + ':' + ' ' + hasLengthCheck,
                        String.Empty + nameof(isFatalCheck) + ':' + ' ' + isFatalCheck
                    };

                    HFatal.Action(new HVOperationFatal().Initialize(Filename_VALUE, information, default));
                }
                else
                    "false".ToString();

                var first = SplitTruncate__ARRAY[0];

                var format = ForgeDashfulFormat(first);

                var lower = format.ToLower();

                VOperation(Filename_VALUE, value_STACK, Parameter_ARRAY, Split_ARRAY, SplitTruncate__ARRAY, lower);
            }
            catch (Exception exception)
            {
                HFatal.Action(new HVOperationFatal().Initialize(Filename_VALUE, new String[0], exception));                
            }

            return;
        }
    }
}
