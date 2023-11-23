using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Materialchain
    {
        public static Materialchain MakeMaterialchainTemplate(Materialinfo Materialinfo_VALUE, Materialquery[] Materialquery_ARRAY, Materialquery[] MaterialqueryIsolate__ARRAY)
        {
            Materialchain materialchainResult = default;

            var Materialquery_LIST = new ArrayList(Materialquery_ARRAY);

            var MaterialqueryIsolate__LIST = new ArrayList(MaterialqueryIsolate__ARRAY);

            var Materialquery_REFLECT = (Materialquery[])(Materialquery_LIST.ToArray(typeof(Materialquery)) as Array);

            var MaterialqueryIsolate__REFLECT = (Materialquery[])(MaterialqueryIsolate__LIST.ToArray(typeof(Materialquery)) as Array);

            Materialchain materialchain;

            materialchain = new Materialchain(Materialinfo_VALUE, Materialquery_REFLECT, MaterialqueryIsolate__ARRAY);

            materialchainResult = materialchain;

            return materialchainResult;
        }
    }
}
