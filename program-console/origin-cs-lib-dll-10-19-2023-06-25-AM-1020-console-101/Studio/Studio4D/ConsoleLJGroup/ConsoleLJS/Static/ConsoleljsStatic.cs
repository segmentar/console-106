using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static void Procedure()
        {
            ConsoleLJPolicy.ConsoleLJDebugPolicy = true;

            ConsoleLJPolicy.ConsoleLJInfoPolicy = true;

            MaterialreflectPolicy.MaterialreflectDebugPolicy = true;

            MaterialreflectPolicy.MaterialreflectInfoPolicy = true;

            ExpressionPolicy.ExpressionDebugPolicy = true;

            ExpressionPolicy.ExpressionInfoPolicy = true;

            ContributePolicy.ContributeDebugPolicy = true;

            ContributePolicy.ContributeInfoPolicy = true;

            MaterialPolicy.MaterialDebugPolicy = true;

            MaterialPolicy.MaterialInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            return;
        }

        public static void Raise()
        {
            if (ConsoleLJPolicy.ConsoleLJInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(ConsoleLJ)}Info", ConsoleLJPolicy.ConsoleLJArrayList.ToArray());
            }
            else
                "false".ToString();

            if (MaterialreflectPolicy.MaterialreflectInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Materialreflect)}Info", MaterialreflectPolicy.MaterialreflectArrayList.ToArray());
            }
            else
                "false".ToString();

            if (ExpressionPolicy.ExpressionInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info", ExpressionPolicy.ExpressionArrayList.ToArray());
            }
            else
                "false".ToString();

            if (ContributePolicy.ContributeInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Contribute)}Info", ContributePolicy.ContributeArrayList.ToArray());
            }
            else
                "false".ToString();
            
            if (MaterialPolicy.MaterialInfoPolicy is true)
            {
                Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Material)}Info", MaterialPolicy.MaterialArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle(Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is true)
            {
                ArchitectureConsoleLJZeroTen.PropagateDebug = true;
            }
            else
                "false".ToString();

            if (ArchitectureConsoleLJZeroTen.PropagateDebug is true)
            {
                Procedure();
            }
            else
                "false".ToString();

            Manual();

            if (ArchitectureConsoleLJZeroTen.PropagateDebug is true)
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((Object sender, EventArgs e) => {

                    Raise();
                });
            }
            else
                "false".ToString();

            return;
        }

        static ConsoleLJS()
        {
            return;
        }
    }
}
