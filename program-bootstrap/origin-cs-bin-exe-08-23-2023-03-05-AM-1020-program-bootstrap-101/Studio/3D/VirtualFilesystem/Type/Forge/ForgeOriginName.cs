using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        public static String ForgeOriginName(String name, String application, String version)
        {
            String stringResult = default;

            var month = DateTime.Now.ToString("MM");

            var day = DateTime.Now.ToString("dd");

            var year = DateTime.Now.ToString("yyyy");

            var hour = DateTime.Now.ToString("hh");

            var minute = DateTime.Now.ToString("mm");

            var meridiem = DateTime.Now.ToString("tt");

            var path_NAME = $"origin-cs-{application}-{month}-{day}-{year}-{hour}-{minute}-{meridiem}-1020-{name}-{version}";

            var result = path_NAME;

            stringResult = result;

            return stringResult;
        }
    }
}
