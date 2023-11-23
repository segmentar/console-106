using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleSetupThreeThird(String[] array_SPLIT, String item_LOWER, Int32 item_LENGTH, Boolean answer_LENGTH_has)
        {
            InputHandler(array_SPLIT, item_LOWER, item_LENGTH, answer_LENGTH_has);

            CallHandler(array_SPLIT, item_LOWER, item_LENGTH, answer_LENGTH_has);

            return;
        }
    }
}
