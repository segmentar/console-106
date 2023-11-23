using Core;

namespace Core
{ 
    public partial class ScopeCode
    {
        public enum RenderPath
        {
            Unset,
            Core_Scope_Debug,
            Core_Scope_Info,
            Core_Scope_Render,
            Core_Scope_Fatal
        }

        public enum StudioPath
        {
            Unset,
            Studio1D,
            Studio2D,
            Studio3D,
            Studio4D
        }
    }
}
