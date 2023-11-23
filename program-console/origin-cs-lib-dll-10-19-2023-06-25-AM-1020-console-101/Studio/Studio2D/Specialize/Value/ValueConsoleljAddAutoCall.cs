using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class SpecializeConsoleLJ
    {
        public static void ValueConsoleLJAddAutoCall(String item_VALUE)
        {
            var tab = Convert.ToChar(9);

            String stringItem;

            stringItem = new String(tab, 2);

            var concat = String.Concat(stringItem + item_VALUE + '\n');

            ArchitectureConsoleLJOneFirst.AutoCommandStringBuilder.Insert(ArchitectureConsoleLJOneFirst.AutoCommandStringBuilder.Length, concat);

            return;
        }
    }
}
