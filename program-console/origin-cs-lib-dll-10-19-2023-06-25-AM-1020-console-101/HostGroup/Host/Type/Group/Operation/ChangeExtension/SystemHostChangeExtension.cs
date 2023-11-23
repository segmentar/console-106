using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Host
    {
        public static void SystemHostChangeExtension(Expression Expression_VALUE, String[] Parameter_ARRAY)
        {
            try
            {
                Boolean hasLengthCheck, isFatalCheck;

                hasLengthCheck = Parameter_ARRAY.Length.Equals(2) is true;

                isFatalCheck = hasLengthCheck is false;

                if (isFatalCheck is true)
                {
                    var information = new String[] {
                    
                        String.Empty + nameof(hasLengthCheck) + ':' + ' ' + hasLengthCheck,
                        String.Empty + nameof(isFatalCheck) + ':' + ' ' + isFatalCheck
                    };

                    HHFatal.Action(new SystemHostChangeExtensionHHFatal().Initialize(Expression_VALUE, information, default));
                }
                else
                    "false".ToString();

                var Onefirst_PARAMETER = Parameter_ARRAY[0];

                Expression_VALUE.IView(Expression_VALUE);

                var Onefirst_PEEK = Expression_VALUE.CPeek(Onefirst_PARAMETER);

                Expression_VALUE.IView(Onefirst_PEEK);

                var Onefirst_BRUTE = Expression_VALUE.IBrute(Onefirst_PEEK);

                Expression_VALUE.IBrute(Onefirst_BRUTE);

                var Onefirst_VALUE = Onefirst_BRUTE.StringIdentity.StringValue;

                var Twosecond_PARAMETER = Parameter_ARRAY[1];

                Expression_VALUE.IView(Expression_VALUE);

                var Twosecond_PEEK = Expression_VALUE.CPeek(Twosecond_PARAMETER);

                Expression_VALUE.IView(Twosecond_PEEK);

                var Twosecond_BRUTE = Expression_VALUE.IBrute(Twosecond_PEEK);

                Expression_VALUE.IBrute(Twosecond_BRUTE);

                var Twosecond_VALUE = Twosecond_BRUTE.StringIdentity.StringValue;
                
                var path__CHANGE_EXTENSION = Path.ChangeExtension(Onefirst_VALUE, Twosecond_VALUE);

                var expression = new ExpressionSimple(path__CHANGE_EXTENSION, default(Object)).Result;

                Expression_VALUE.IView(Onefirst_PEEK);

                Expression_VALUE.IBrute(expression);

            } catch (Exception exception)
            {
                HHFatal.Action(new SystemHostChangeExtensionHHFatal().Initialize(Expression_VALUE, new String[0], exception));
            }
            return;
        }
    }
}
