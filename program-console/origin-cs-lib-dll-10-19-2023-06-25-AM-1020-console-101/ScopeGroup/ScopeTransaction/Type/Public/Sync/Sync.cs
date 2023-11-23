using Core;

namespace Core
{
    using System;

    public partial class ScopeTransaction
    {
        public void Sync()
        {
            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[0] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[0];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[1] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[1];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[2] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[2];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[3] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[3];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[4] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[4];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[5] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[5];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[6] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[6];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[7] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[7];

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[8] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = WindowArray[8];

            return;
        }
    }
}
