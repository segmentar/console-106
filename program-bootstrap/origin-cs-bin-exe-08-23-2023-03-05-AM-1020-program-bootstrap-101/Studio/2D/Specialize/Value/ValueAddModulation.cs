using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void ValueAddModulation(String item_NAME, String item_NAMESPACE, String item_COUNT)
        {
            var separator = String.Empty;

            separator = separator + '\n';

            separator = separator + '\t';

            separator = separator + $"module-{item_NAME}-{item_NAMESPACE}-{item_COUNT}";

            ArchitectureTwoSecond.ModuleStringBuilger.Insert(ArchitectureTwoSecond.ModuleStringBuilger.Length, separator);

            return;
        }
    }
}
