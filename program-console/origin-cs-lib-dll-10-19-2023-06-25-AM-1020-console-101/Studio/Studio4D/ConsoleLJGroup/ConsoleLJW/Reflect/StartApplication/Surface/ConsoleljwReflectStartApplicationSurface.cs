using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJW
    {
        public static void ConsoleLJStartApplicationSurface(Boolean reflect)
        {
            if (reflect)
            {
                ConsoleLJStartApplicationTask();
            }
            else
            {
                ConsoleLJStartApplicationThread();
            }

            return;
        }
    }
}
