using Core;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramNameValueContainer()
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            foreach (Tuple<String, Object> tuple in ForgeNameValueArray())
            {
                list.Add(tuple);

                continue;
            }

            listResult = list;

            return listResult;
        }
    }
}
