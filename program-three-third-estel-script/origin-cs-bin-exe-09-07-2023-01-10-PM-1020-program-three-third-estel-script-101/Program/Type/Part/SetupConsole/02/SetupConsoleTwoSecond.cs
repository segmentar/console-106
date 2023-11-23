using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void SetupConsoleTwoSecond()
        {
            do
            {
                SpecializeConsoleLJ.GetConsoleLJInstance().Clear();

                SpecializeConsoleLJ.GetConsoleLJInstance().WriteLine(ConsoleDescriptor());

                var line = SpecializeConsoleLJ.GetConsoleLJInstance().ReadLine();

                Boolean hasLengthCheck;

                hasLengthCheck = (line.Length > 0) is true;

                var whitespace = Convert.ToChar(32);

                var split = line.Split(new String[] { whitespace.ToString() }, StringSplitOptions.None);

                var lower = line.ToLower();

                var length = split.Length;

                SetupConsoleTreeThird(split, lower, length, hasLengthCheck);

                Boolean isEscapeCheck;

                isEscapeCheck = lower.Equals("escape") is true;

                if (isEscapeCheck)
                {
                    SpecializeConsoleLJ.GetConsoleLJInstance().Clear();

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
