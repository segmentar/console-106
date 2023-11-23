using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AddMaterial(Materialchain Materialchain_VALUE)
        {
            MeasureValidate.MaterialchainArrayList.Add(Materialchain_VALUE);

            return;
        }
    }
}
