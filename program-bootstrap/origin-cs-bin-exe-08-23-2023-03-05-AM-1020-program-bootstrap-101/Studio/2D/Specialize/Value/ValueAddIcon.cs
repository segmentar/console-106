using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void ValueAddIcon(String item_NAME, String item_SEED, String item_COUNT, String item__BACK_COLOR, String item__FORE_COLOR, String item__BACK_RATIO, String item__FORE_RATIO)
        {
            var separator = String.Empty;

            separator = separator + '\n';

            separator = separator + '\t';

            separator = separator + $"icon-{item_NAME}-{item_SEED}-{item_COUNT}-{item__FORE_COLOR}-{item__BACK_COLOR}-{item__BACK_RATIO}-{item__FORE_RATIO}";

            ArchitectureTwoSecond.IconStringBuilder.Insert(ArchitectureTwoSecond.IconStringBuilder.Length, separator);

            return;
        }
    }
}
