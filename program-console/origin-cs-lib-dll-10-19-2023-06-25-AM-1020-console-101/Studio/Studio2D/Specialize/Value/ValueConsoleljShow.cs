using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    using System.Threading;

    public partial class SpecializeConsoleLJ
    {
        public static void ValueConsoleLJShow(String[] Argument_ARRAY, Int32 Timeout_VALUE, Boolean answer_INTEROP_has, Boolean answer_REFLECT_is)
        {
            if (answer_INTEROP_has is true)
            {
                Interop.Main01CL(Argument_ARRAY);
            }
            else
                "false".ToString();

            ConsoleLJ consoleLJ;

            consoleLJ = ConsoleLJ.MakeConsoleLJDefaultSurface();

            SetConsoleLJInstance(consoleLJ, true);

            ConsoleLJW.ConsoleLJStartApplicationSurface(answer_REFLECT_is);

            Thread.Sleep(Timeout_VALUE);

            GetConsoleLJInstance().Running(true);

            return;
        }
    }
}
