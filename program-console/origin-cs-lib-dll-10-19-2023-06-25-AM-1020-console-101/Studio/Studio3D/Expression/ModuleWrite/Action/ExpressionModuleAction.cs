using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static ExpressionModuleWrite ExpressionModuleAction(Expression item_EXPRESSION, Boolean answer_POLICY_has)
        {
            ExpressionModuleWrite module;

            module = ExpressionModuleDefault(item_EXPRESSION);

            if (answer_POLICY_has is true)
            {
                try
                {
                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}01", module.Expression);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}02", module.ExpressionArray);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}03", module.ExpressionObjectArray);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}04", module.ExpressionLength);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWriteIO)}05", BitConverter.ToString(module.HeaderMemoryStream.ToArray()));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWriteIO)}06", String.Join('\n'.ToString(), module.IdentityObjectStartAddressArray));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWriteIO)}07", String.Join('\n'.ToString(), module.IdentityObjectEndAddressArray));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWriteIO)}08", BitConverter.ToString(module.ObjectIdentityMemoryStream.ToArray()));

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}10", module.First.Function);

                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}20", module.Second.Function);
                    
                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}30", module.Third.Function);
                    
                    ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryConsoleLJ.Core_ConsoleLJ_Info}-{nameof(Expression)}Info-{nameof(ExpressionModuleWrite)}40", module.Fourth.Function);
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
