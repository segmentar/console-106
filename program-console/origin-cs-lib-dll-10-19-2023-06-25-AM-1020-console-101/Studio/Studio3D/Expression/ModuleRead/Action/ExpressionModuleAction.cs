using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleRead
    {
        public static ExpressionModuleRead ExpressionModuleAction(FileStream item__FILE_STREAM, Boolean answer_POLICY_is)
        {
            ExpressionModuleRead module;

            module = ExpressionModuleDefault(item__FILE_STREAM);

            if (answer_POLICY_is is true)
            {
                try
                {
                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleReadIO)}01", module.Expression);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleRead)}10", module.First.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleRead)}20", module.Second.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleRead)}30", module.Third.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleRead)}40", module.Fourth.Function);
                }
                catch (Exception exception)
                {
                    ConsoleLJS.Log(false, exception.ToString());
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
