using Core;

namespace Core
{
    using System;

    public partial class Scopearch
    {
        public static void Option()
        {
            try
            {
                Boolean shouldReturnCheck;

                shouldReturnCheck = MaterialqueryValue.Data.Runtime.QueryType.Equals(MaterialqueryCode.QueryType.Option) is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                Template.Data.MeasureValidate.ValidateMaterialquery[MaterialqueryValue] = true;

                if (ShouldLog is true)
                {
                    ConsoleLJS.Log(false, $"found option [{MaterialqueryValue.Data.SubsequentStringValue.StringValue}] [{Position}]");
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalOption().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
