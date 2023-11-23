using Core;

namespace Core
{
    public partial class ConsoleLJCode
    {
        public enum SpecialDirectory
        {
            Unset,
            Core,
            Core_Debug,
            Core_Info,
            Core_Action,
            Core_Interop,
        }

        public enum SpecialDirectoryConsoleLJ
        {
            Unset,
            Core_ConsoleLJ_Debug,
            Core_ConsoleLJ_Info,
            Core_ConsoleLJ_Action,
            Core_ConsoleLJ_Domain,
            Core_ConsoleLJ_Application
        }

        public enum SpecialDirectoryEstelScript
        {
            Unset,
            Core_EstelScript_Fatal
        }
    }
}