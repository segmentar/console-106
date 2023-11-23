using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class ConsoleLJ
    {
        public static void CallHandlerTwoSecond(String[] array__END_POINT, String item_CALL, String item_FILE, String[] array_ARGUMENT)
        {
            var list = new ArrayList(array_ARGUMENT);

            Boolean isEchoContagiousCheck;

            isEchoContagiousCheck = list.Contains("echo") is true;

            if (isEchoContagiousCheck)
            {
                ConsoleLJS.Log(false, $"<{String.Join(','.ToString(), array_ARGUMENT)}> [{item_FILE}]");
            }
            else
            {
                try
                {
                    Interop.Callf01OL(1, item_FILE, array_ARGUMENT);

                }
                catch (Exception exception)
                {
                    ConsoleLJS.Log(false, exception);
                }
            }

            return;
        }
    }
}
