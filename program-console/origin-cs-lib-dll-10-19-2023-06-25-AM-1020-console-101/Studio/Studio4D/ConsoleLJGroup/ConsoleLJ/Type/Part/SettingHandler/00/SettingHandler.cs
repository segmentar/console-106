using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String>[] SettingHandler(InteropStartInfo item__INTEROP_START_INFO, Tuple<String, Object>[] array__NAME_VALUE)
        {
            Tuple<String, String>[] arrayResult = default;

            InteropStartInfo.InteropStartInfoApplyForceVoid(item__INTEROP_START_INFO);

            var tuple = ForgeSettingFile__PATH_TEXT_HAS_INTEROP_START_INFO(ImmutableConsoleLJZeroTen.SettingName, ImmutableConsoleLJZeroTen.SettingExtension, true);

            String text = tuple.Item2;

            Boolean hasInteropStartInfo = tuple.Item3;

            InteropStartInfo interopStartInfo = tuple.Item4;

            if (hasInteropStartInfo is true)
            {
                InteropStartInfo.InteropStartInfoApplyForceVoid(interopStartInfo);
            }
            else
                "false".ToString();

            var carriage_return = Convert.ToChar(13);

            var line_feed = Convert.ToChar(10);

            var align__CONCAT_NEW_LINE = String.Concat(carriage_return, line_feed);

            var new_line = align__CONCAT_NEW_LINE;

            var whitespace = Convert.ToChar(32);

            var replace = text.Replace(new_line.ToString(), whitespace.ToString());

            arrayResult = SettingHandlerOneFirst(item__INTEROP_START_INFO, array__NAME_VALUE, replace);

            return arrayResult;
        }
    }
}
