using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static Action ScopeMainAction()
        {
            Action actionResult = default;

            Action action;

            action = new Action(ScopeMainTargetSTA);

            actionResult = action;

            return actionResult;
        }
    }
}
