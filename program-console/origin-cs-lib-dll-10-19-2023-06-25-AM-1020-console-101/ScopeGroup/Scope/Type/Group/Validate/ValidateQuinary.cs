using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ValidateQuinary()
        {
            foreach (Materialchain materialchain in MeasureValidate.MaterialchainArrayList)
            {
                Boolean isValidateCheck, shouldContinueCheck;

                isValidateCheck = MeasureValidate.ValidateMaterialchain[materialchain] is true;

                shouldContinueCheck = isValidateCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var Entity_LOG = "log";

                if (materialchain.Materialinfo.Name.StringValue.Contains(Entity_LOG) is true)
                {
                    DirectionRender(true);

                    DirectionPause();
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
