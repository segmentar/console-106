using Core;

namespace Core
{
    using System;

    public partial class Materialquery
    {
        public static Materialquery[] FunctionIsolatelayerSetSurface(Materialquery[] Materialquery_ARRAY, Int32 Isolate_INTEGER)
        {
            Materialquery[] arrayResult = default;

            var list = FunctionIsolatelayerSet(Materialquery_ARRAY, Isolate_INTEGER);

            var array = new Materialquery[list.Count];

            list.CopyTo(array, MaterialPolicy.MaterialIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
