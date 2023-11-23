using Core;

namespace Core
{
    using System;

    public partial class ScopeDisplayContext
    {
        public ScopeDisplayContext Show()
        {
            foreach (ScopeDisplay scopeDisplay in ScopeDisplayArrayList)
            {
                scopeDisplay.Show(MainForm);

                continue;
            }

            return this;
        }
    }
}
