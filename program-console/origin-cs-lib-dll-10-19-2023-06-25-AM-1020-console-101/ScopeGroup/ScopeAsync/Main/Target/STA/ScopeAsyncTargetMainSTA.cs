using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        [STAThread]
        public static void ScopeMainTargetSTA()
        {
            ScopeMainTarget();

            return;
        }
    }
}
