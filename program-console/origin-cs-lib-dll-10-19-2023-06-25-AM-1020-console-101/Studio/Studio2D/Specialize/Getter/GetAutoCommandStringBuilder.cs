using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    internal partial class Specialized
    {
        internal static String[] GetAutoCommandStringBuilder()
        {
            String[] arrayResult = default;

            var line_feed = Convert.ToChar(10);

            String stringItem;

            stringItem = ArchitectureConsoleLJOneFirst.AutoCommandStringBuilder.ToString();

            var split = stringItem.Split(new String[] { line_feed.ToString() }, StringSplitOptions.None);

            var align__ROTH_INDEXER = (split.Length - 1);

            var length = align__ROTH_INDEXER;

            var array = new String[length];

            Array.Copy(split, align__ROTH_INDEXER, array, 0, length);

            arrayResult = array;

            return arrayResult;
        }
    }
}
