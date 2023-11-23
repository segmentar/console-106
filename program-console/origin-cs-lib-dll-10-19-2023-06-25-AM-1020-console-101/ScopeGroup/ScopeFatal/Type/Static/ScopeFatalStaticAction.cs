using Core;

namespace Core
{
    using System;

    public partial class ScopeFatal
    {
        public static ScopeFatal Action(ScopeFatal ScopeFatal__VALUE)
        {
            Scope.Render($"{ScopeCode.RenderPath.Core_Scope_Fatal}-{ScopeFatal__VALUE.GetType().Name}", ScopeFatal__VALUE.ActionDescriptor());

            return ScopeFatal__VALUE;
        }
    }
}
