using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct ScopeMeasureValidate
    {
        public ArrayList MaterialchainArrayList;

        public Dictionary<Materialchain, Boolean> ValidateMaterialchain;

        public Dictionary<Materialquery, Boolean> ValidateMaterialquery;
    }
}
