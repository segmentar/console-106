using Core;

namespace Core
{
    using System;

    public partial class Scopearch
    {
        public static void Require()
        {
            try
            {
                Boolean shouldReturnContiniousCheck;

                shouldReturnContiniousCheck = MaterialqueryValue.Data.Runtime.QueryType.Equals(MaterialqueryCode.QueryType.Require) is false;

                if (shouldReturnContiniousCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var query = MaterialqueryValue.Data.SubsequentStringValue.StringValue;

                var index = Template.Data.MeasureFileArray.Text.StringValue.IndexOf(query, Position);

                Boolean isEqualCheck;

                isEqualCheck = index.Equals(-1) is true;

                shouldReturnContiniousCheck = isEqualCheck is true;

                if (shouldReturnContiniousCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                Position = index;

                Skip = query.Length;

                Template.Data.MeasureValidate.ValidateMaterialquery[MaterialqueryValue] = true;

                if (ShouldLog is true)
                {
                    ConsoleLJS.Log(false, $"found required [{MaterialqueryValue.Data.SubsequentStringValue.StringValue}] [{Position}]");
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalRequire().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
