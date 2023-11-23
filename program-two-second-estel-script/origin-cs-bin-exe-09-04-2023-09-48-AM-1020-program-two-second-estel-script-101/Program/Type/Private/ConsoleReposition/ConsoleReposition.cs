using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void ConsoleReposition(Boolean reset, Boolean hide, Boolean clear)
        {
            if (reset)
            {
                Console.CursorLeft = 0;

                Console.CursorTop = 0;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }
            else
            {
                Console.CursorLeft = 16;

                Console.CursorTop = 25;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            }

            if (hide)
            {
                Console.CursorVisible = false;
            }
            else
            {
                Console.CursorVisible = true;
            }

            if (clear is true)
            {
                Console.Clear();
            }
            else
                "false".ToString();

            return;
        }
    }
}
