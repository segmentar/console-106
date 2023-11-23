using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleRead
    {
        public static ContributeModuleRead ContributeModuleAction(FileStream item__FILE_STREAM, Boolean answer_RENDER_should)
        {
            ContributeModuleRead module;

            module = ContributeModuleDefault(item__FILE_STREAM);

            try
            {
                if (answer_RENDER_should is true)
                {
                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleRead)}Action-{nameof(ContributeModuleReadCycle)}10", module.FunctionRead);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleRead)}Action-{nameof(ContributeModuleReadCycle)}20", module.FunctionHeader);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleRead)}Action-{nameof(ContributeModuleReadCycle)}30", String.Join('\n'.ToString(), module.FunctionArrayA));

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleRead)}Action-{nameof(ContributeModuleReadCycle)}40", module.FunctionAA);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleRead)}Action-{nameof(ContributeModuleReadInline)}50", module.First);
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                ConsoleLJS.Log(false, exception);
            }

            return module;
        }
    }
}
