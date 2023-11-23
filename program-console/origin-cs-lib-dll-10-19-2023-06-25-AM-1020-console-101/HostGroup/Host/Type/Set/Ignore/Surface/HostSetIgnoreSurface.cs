using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static String[] HostIgnoreSetSurface(String[] File_ARRAY, params String[] Ignore_ARRAY)
        {
            String[] arrayResult = default;

            var list = HostIgnoreSet(File_ARRAY, Ignore_ARRAY);

            var array = new String[list.Count];

            list.CopyTo(array, ScopePolicy.ScopeIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
