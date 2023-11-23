using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void HUnlock(String Filename_VALUE, String[] SplitTruncate_ARRAY)
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

                    HFatal.Action(new HUnlockFatal().Initialize(Filename_VALUE, information, default));
                }
                else
                    "false".ToString();

                var first = SplitTruncate_ARRAY[0];

                var format = ForgeDashlessFormat(first);

                Unlock(format);

            } catch (Exception exception)
            {
                HFatal.Action(new HUnlockFatal().Initialize(Filename_VALUE, new String[0], exception));
            }

            return;
        }
    }
}
