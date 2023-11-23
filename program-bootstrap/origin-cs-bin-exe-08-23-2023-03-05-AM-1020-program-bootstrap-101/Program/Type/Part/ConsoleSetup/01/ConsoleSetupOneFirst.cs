using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleSetupOneFirst()
        {
            SpecializeConsoleLJ.ValConsoleLJShow(true, 1000);

            SpecializeConsoleLJ.GetConsoleLJInstance().Title(ImmutableOneFirst.Title);

            SpecializeConsoleLJ.GetConsoleLJInstance().Style(ConsoleLJCode.GUIStyle.CommandBackColor, "green");

            SpecializeConsoleLJ.GetConsoleLJInstance().Clear();

            return;
        }
    }
}
