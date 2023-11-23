using Core;

namespace Core
{
    using System;

    public partial class ExpressionCode
    {
        public enum RenderPath
        {
            Unset,
            Core_Expression,
            Core_Expression_Info,
            Core_Expression_Debug,
            Core_Expression_Fatal
        }
    }
}
