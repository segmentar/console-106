using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Host
    {
        public static void SystemHostCurrentDirectory(Expression Expression_VALUE, String[] Parameter_ARRAY)
        {
            try
            {
                Boolean hasLengthCheck, isFatalCheck;

                hasLengthCheck = Parameter_ARRAY.Length.Equals(1) is true;

                isFatalCheck = hasLengthCheck is false;

                if (isFatalCheck is true)
                {
                    var information = new String[] {

                        String.Empty + nameof(hasLengthCheck) + ':' + ' ' + hasLengthCheck,
                        String.Empty + nameof(isFatalCheck) + ':' + ' ' + isFatalCheck
                    };

                    HHFatal.Action(new SystemHostCurrenDirectoryHHFatal().Initialize(Expression_VALUE, information, default));
                }
                else
                    "false".ToString();

                Expression_VALUE.IView(Expression_VALUE);

                var Onefirst_PARAMETER = Parameter_ARRAY[0];

                var Onefirst_PEEK = Expression_VALUE.CPeek(Onefirst_PARAMETER);

                var path__CURRENT_DIRECTORY = Directory.GetCurrentDirectory();

                Expression_VALUE.ULock(Onefirst_PARAMETER);

                Expression_VALUE.Brute(path__CURRENT_DIRECTORY);

            } catch (Exception exception)
            {
                HHFatal.Action(new SystemHostCurrenDirectoryHHFatal().Initialize(Expression_VALUE, new String[0], exception));
            }

            return;
        }
    }
}
