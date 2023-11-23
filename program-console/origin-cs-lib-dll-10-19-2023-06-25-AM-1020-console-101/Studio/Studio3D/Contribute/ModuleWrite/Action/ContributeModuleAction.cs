using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWrite
    {
        public static ContributeModuleWrite ContributeModuleAction(Contribute[] array_CONTRIBUTE, Boolean answer_RENDER_should)
        {
            ContributeModuleWrite module;

            module = ContributeModuleDefault(array_CONTRIBUTE);

            try
            {
                if (answer_RENDER_should is true)
                {
                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleWrite)}Action-{nameof(ContributeModuleWriteCycle)}10", module.FunctionWrite);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleWrite)}Action-{nameof(ContributeModuleWriteInline)}20", module.First.Function);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleWrite)}Action-{nameof(ContributeModuleWriteInline)}30", module.Second.Function);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleWrite)}Action-{nameof(ContributeModuleWriteInline)}40", module.Third.Function);

                    Contribute.Render($"{ContributeCode.SpecialPath.Core_Contribute_Action}-{nameof(ContributeModuleWrite)}Action-{nameof(ContributeModuleWriteCycle)}50", module.FunctionHeader);
                }
                else
                    "false".ToString();

                if (ContributePolicy.ContributeStreamPolicy is true)
                {
                    module.Streamline.HeaderMemoryStream.Close();

                    module.Streamline.HeaderMemoryStream.Dispose();

                    module.Streamline.MemoryStreamA.Close();

                    module.Streamline.MemoryStreamA.Dispose();

                    module.Streamline.MemoryStreamB.Close();

                    module.Streamline.MemoryStreamB.Dispose();

                    module.Streamline.MemoryStreamC.Close();

                    module.Streamline.MemoryStreamC.Dispose();

                    module.Streamline.MemoryStreamD.Close();

                    module.Streamline.MemoryStreamD.Dispose();

                    module.Streamline.ObjectIdentityMemoryStream.Close();

                    module.Streamline.ObjectIdentityMemoryStream.Dispose();

                    module.Streamline.MemoryStream.Close();

                    module.Streamline.MemoryStream.Dispose();
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
