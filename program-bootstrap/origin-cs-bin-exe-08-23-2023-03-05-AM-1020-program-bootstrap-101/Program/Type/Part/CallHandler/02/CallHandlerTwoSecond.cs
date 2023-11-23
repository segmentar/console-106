using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        public static void CallHandlerTwoSecond(String[] array_SPLIT, String item_LOWER, Int32 item_LENGTH, Boolean hasLength, String item_CALL, String item_ESCAPE, Char align_CHARACTER, String[] array_ARGUMENT)
        {
            Specialize.SetEscapeCharacter(align_CHARACTER, true);

            Interop.Calf01OL(1, array_ARGUMENT);

            SpecializeConsoleLJ.GetConsoleLJInstance().Escape();

            return;
        }
    }
}
