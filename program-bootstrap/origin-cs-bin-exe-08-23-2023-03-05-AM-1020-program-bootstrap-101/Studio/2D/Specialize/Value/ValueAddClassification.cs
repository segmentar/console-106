using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    public partial class Specialize
    {
        public static void ValueAddClassification(String item_NAME, String item_NAMESPACE, String answer_STATIC_is)
        {
            var separator = String.Empty;

            separator = separator + '\n';

            separator = separator + '\t';

            separator = separator + $"class-{item_NAME}-{item_NAMESPACE}-{answer_STATIC_is}";

            ArchitectureTwoSecond.ClassStringBuilder.Insert(ArchitectureTwoSecond.ClassStringBuilder.Length, separator);

            return;
        }
    }
}
