using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String, String>[] SettingHandlerOneFirst(InteropStartInfo item__INTEROP_START_INFO, Tuple<String, Object>[] array__NAME_VALUE, String item_TEXT)
        {
            Tuple<String, String>[] arrayResult = default;

            var array = EndPointHandler(item_TEXT, array__NAME_VALUE);

            arrayResult = array;

            return arrayResult;
        }
    }
}
