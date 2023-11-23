using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scope
    {
        public static void MeasureValidateRuntime()
        {
            MeasureValidate.MaterialchainArrayList = new ArrayList();

            MeasureValidate.ValidateMaterialchain = new Dictionary<Materialchain, Boolean>();

            MeasureValidate.ValidateMaterialquery = new Dictionary<Materialquery, Boolean>();

            return;
        }
    }
}