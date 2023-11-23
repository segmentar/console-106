using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal void ConsoleSetupTwoSecond()
        {
            do
            {
                SpecializeConsoleLJ.GetConsoleLJInstance().Clear();

                SpecializeConsoleLJ.GetConsoleLJInstance().WriteLine(ConsoleDescriptor());

                var line = SpecializeConsoleLJ.GetConsoleLJInstance().ReadLine();

                var lower = line.ToLower();

                var whitespace = Convert.ToChar(32);

                var split = line.Split(new String[] { whitespace.ToString() }, StringSplitOptions.RemoveEmptyEntries);

                var length = split.Length;

                var boolean_match__MORE_THAN = (length > 0);

                Boolean hasLengthCheck;

                hasLengthCheck = boolean_match__MORE_THAN is true;

                ConsoleSetupThreeThird(split, lower, length, hasLengthCheck);

                Boolean isEscape;

                isEscape = lower.Equals("escape") is true;

                if (isEscape is true)
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
