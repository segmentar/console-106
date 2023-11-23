using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleAction(Boolean free, Boolean autoCall, Boolean explorer)
        {
            ProgramModule module;

            if (free is true)
            {
                ConsoleLJS.Free();
            }
            else
                "false".ToString();

            module = ProgramModuleDefault();

            if (autoCall is true)
            {
                SpecializeConsoleLJ.ValueConsoleLJAutoCall(Program.ForgeNameValueArray());
            }
            else
                "false".ToString();

            if (explorer is true)
            {
                ConsoleLJS.Explorer(1, Directory.GetCurrentDirectory());
            }
            else
                "false".ToString();

            return module;
        }
    }
}
