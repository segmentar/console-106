using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Interop
    {
        public static void Reff04IL()
        {
            ArrayList arrayList;

            arrayList = new ArrayList(Program.ArgumentArray);

            ArchitectureOneFirst.ArgumentList = arrayList;

            return;
        }
    }
}
