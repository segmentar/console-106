using Core;

namespace Core
{
	using System;

	internal partial class Program
	{
		internal void SetupConsoleTwoSecond()
		{
            do
            {
                ConsoleReposition(true, true, true);

                Console.Clear();

                Console.Out.WriteLine(ConsoleDescriptor());

                ConsoleReposition(false, false, false);

                var line = Console.In.ReadLine();

                var split = line.Split();

                var lower = line.ToLower();

                var boolean_match__BIGGER_THAN = (split.Length > 0);

                Boolean hasLengthCheck;

                hasLengthCheck = boolean_match__BIGGER_THAN is true;

                SetupConsoleThreeThird(split, lower, hasLengthCheck);

                Boolean isEscapeCheck;

                isEscapeCheck = (lower == "escape") is true;

                if (isEscapeCheck is true)
                {
                    ConsoleReposition(true, true, true);

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