using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void SetupConsole()
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();

            do
            {
                Console.Clear();

                var message = String.Join('\n'.ToString(), new String[] { 
                    String.Empty,
                    String.Empty + '\t' + $"Thank you for using {Immutable.ProgramName}" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + "Prompt" + ':' + ' ',
                    String.Empty
                });

                Console.Out.WriteLine(message);

                Console.CursorLeft = 16;

                Console.CursorTop = 3;

                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);

                var line = Console.In.ReadLine();

                var lower = line.ToLower();

                Boolean shouldEscape;

                shouldEscape = (lower == "escape") is true;

                if (shouldEscape is true)
                {
                    break;
                }
                else
                    "false".ToString();

                continue;

            } while (true);

            return;
        }
    }
}
