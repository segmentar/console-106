using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Host
    {
        public static void SystemHostClose(Expression Expression_VALUE, String[] Parameter_ARRAY)
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

                    HHFatal.Action(new SystemHostCloseHHFatal().Initialize(Expression_VALUE, information, default));
                }
                else
                    "false".ToString();

                var Onefirst_PARAMETER = Parameter_ARRAY[0];

                Expression_VALUE.IView(Expression_VALUE);

                var Onefirst_PEEK = Expression_VALUE.CPeek(Onefirst_PARAMETER);

                var reflect = (FileStream)(Onefirst_PEEK.ObjectIdentity as Object);

                reflect.Close();

                reflect.Dispose();

            } catch (Exception exception)
            {
                HHFatal.Action(new SystemHostCloseHHFatal().Initialize(Expression_VALUE, new String[0], exception));
            }

            return;
        }
    }
}
