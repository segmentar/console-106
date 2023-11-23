using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void GlobalLineSync()
        {
            MeasureFlag.GlobalLineFlag = false;

            return;
        }
    }
}
