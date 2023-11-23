using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void HVUnlock(String Filename_VALUE, String[] SplitTruncate_ARRAY)
        {
            try
            {
                Boolean hasLengthCheck, isFatalCheck;

                hasLengthCheck = SplitTruncate_ARRAY.Length.Equals(1) is true;

                isFatalCheck = hasLengthCheck is false;

                if (isFatalCheck is true)
                {
                    var information = new String[] {

                        String.Empty + nameof(hasLengthCheck) + ':' + ' ' + hasLengthCheck,
                        String.Empty + nameof(isFatalCheck) + ':' + ' ' + isFatalCheck
                    };

                    HFatal.Action(new HVUnlockFatal().Initialize(Filename_VALUE, information, default));
                }
                else
                    "false".ToString();

                var first = SplitTruncate_ARRAY[0];

                var format = ForgeDashlessFormat(first);

                VUnlock(format);

            } catch (Exception exception)
            {
                HFatal.Action(new HVUnlockFatal().Initialize(Filename_VALUE, new String[0], exception));
            }

            return;
        }
    }
}
