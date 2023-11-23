using Core;

namespace Core
{
    using System;

    public partial class Materialquery
    {
        public static Materialquery[] FunctionSortrankSetSurface(Materialquery[] Materialquery_ARRAY)
        {
            Materialquery[] arrayResult = default;

            var list = FunctionSortrankSet(Materialquery_ARRAY);

            var array = new Materialquery[list.Count];

            list.CopyTo(array, MaterialPolicy.MaterialIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
