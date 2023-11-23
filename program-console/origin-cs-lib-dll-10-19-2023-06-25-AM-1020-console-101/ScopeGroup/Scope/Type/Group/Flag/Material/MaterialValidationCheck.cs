using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MaterialValidateCheck()
        {
            var boolean_match_VALIDATE_is = true;

            boolean_match_VALIDATE_is = boolean_match_VALIDATE_is && MeasureFlag.MaterialHeaderFlag is true;

            boolean_match_VALIDATE_is = boolean_match_VALIDATE_is && MeasureFlag.MaterialFooterFlag is true;

            Boolean isValidateCheck;

            isValidateCheck = boolean_match_VALIDATE_is is true;

            if (isValidateCheck is true)
            {
                MeasureFlag.MaterialValidateFlag = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
