using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ValidateQuaternary()
        {
            foreach (Materialchain materialchain in MeasureValidate.MaterialchainArrayList)
            {
                var validate = true;

                foreach (Materialquery materialquery in materialchain.MaterialqueryIsolateArray)
                {
                    Boolean isValidateCheck, shouldContinueCheck;

                    isValidateCheck = MeasureValidate.ValidateMaterialquery[materialquery] is true;

                    shouldContinueCheck = isValidateCheck is true;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    validate = false;

                    break;
                }

                if (validate is true)
                {
                    MeasureValidate.ValidateMaterialchain[materialchain] = true;
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
