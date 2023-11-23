using Core;

using Core.DimensionThreeThird;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ProgramModule
    {
        internal static ProgramModule ProgramModuleAction(Boolean interop, Boolean build, Boolean explorer)
        {
            if (interop is true)
            {
                try
                {
                    Interop.Lenf01IL();

                    Interop.Linf02IL();

                    Interop.Extf03IL();

                    Interop.Reff04IL();

                    Interop.Debf05IL();

                    Interop.Chrf06IL();

                    Interop.Escf07IL();

                }
                catch (Exception exception)
                {
                    exception.ToString();

                    ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_Interop}-{nameof(exception)}Interop");
                }
            }
            else
                "false".ToString();

            var item_MODULE = ProgramModuleDefault();

            if (build is true)
            {
                VirtualFilesystem.Build(item_MODULE.First.WorkingDirectory);
            }
            else
                "false".ToString();

            if (explorer is true)
            {
                ConsoleLJ.Explorer(1, Directory.GetCurrentDirectory());
            }
            else
                "false".ToString();

            return item_MODULE;
        }
    }
}
