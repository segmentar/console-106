using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Host
    {
        public static void SystemHostOpenWrite(Expression Expression_VALUE, String[] Parameter_ARRAY)
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

                    HHFatal.Action(new SystemHostOpenWriteHHFatal().Initialize(Expression_VALUE, information, default));
                }
                else
                    "false".ToString();

                Expression_VALUE.IView(Expression_VALUE);

                var Onefirst_PARAMETER = Parameter_ARRAY[0];

                var Onefirst_PEEK = Expression_VALUE.CPeek(Onefirst_PARAMETER);

                Expression_VALUE.IView(Onefirst_PEEK);

                var Onefirst_BRUTE = Expression_VALUE.IBrute(default);

                Expression_VALUE.IBrute(Onefirst_BRUTE);

                var Onefirst_VALUE = Onefirst_BRUTE.StringIdentity.StringValue;

                Expression_VALUE.IView(Expression_VALUE);

                var Twosecond_PARAMETER = Parameter_ARRAY[1];

                var Twosecond_PEEK = Expression_VALUE.CPeek(Twosecond_PARAMETER);

                FileStream fileStream;

                fileStream = File.OpenWrite(Onefirst_VALUE);

                Expression_VALUE.IBind(Twosecond_PEEK, fileStream);
                

            } catch (Exception exception)
            {
                HHFatal.Action(new SystemHostOpenWriteHHFatal().Initialize(Expression_VALUE, new String[0], exception));
            }

            return;
        }
    }
}
