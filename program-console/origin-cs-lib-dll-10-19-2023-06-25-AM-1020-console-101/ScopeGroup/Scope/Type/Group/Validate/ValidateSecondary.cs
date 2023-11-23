using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ValidateSecondary()
        {
            foreach (Materialchain materialchain in MeasureValidate.MaterialchainArrayList)
            {
                MeasureValidate.ValidateMaterialchain.Add(materialchain, false);

                continue;
            }

            foreach (Materialchain materialchain in MeasureValidate.MaterialchainArrayList)
            {
                foreach (Materialquery materialquery in materialchain.MaterialqueryIsolateArray)
                {
                    MeasureValidate.ValidateMaterialquery.Add(materialquery, false);

                    continue;
                }

                continue;
            }

            return;
        }
    }
}
