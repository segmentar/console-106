using Core;

namespace Core
{
    using System;

    public partial class Scopearch
    {
        public static void Separate()
        {
            try
            {
                Boolean shouldReturnCheck;

                shouldReturnCheck = MaterialqueryValue.Data.Runtime.QueryType.Equals(MaterialqueryCode.QueryType.Separate) is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                foreach (Materialquery materialquery in MaterialqueryIsolateArray)
                {
                    Boolean shouldContinueCheck;

                    shouldContinueCheck = materialquery.Data.VirtualName.StringValue.Equals(MaterialqueryValue.Data.IdentityName.StringValue) is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var validate = true;

                    var aoth = MaterialqueryValue.Data.SegmentArray.StringArray.Length;

                    var roth = (aoth - 1);

                    var eoth = MaterialqueryValue.Data.SegmentArray.StringArray[roth];

                    foreach (String segment in MaterialqueryValue.Data.SegmentArray.StringArray)
                    {
                        var entity_EQUAL = Convert.ToChar(61);

                        Boolean hasEqualCheck;

                        hasEqualCheck = segment.Contains(entity_EQUAL.ToString());

                        if (hasEqualCheck is true)
                        {
                            Expression.IView(Expression);

                            var ExpressionPeek__VALUE = Expression.CPeek(MaterialqueryValue.Data.IdentityName.StringValue);

                            Expression.IView(ExpressionPeek__VALUE);

                            var ExpressionBrute__VALUE = ExpressionPeek__VALUE.IBrute(default);

                            ExpressionPeek__VALUE.IBrute(ExpressionBrute__VALUE);

                            var ExpressionValue__VALUE = ExpressionBrute__VALUE.StringIdentity.StringValue;

                            Boolean isEqualCheck;

                            isEqualCheck = ExpressionValue__VALUE.Equals(eoth) is true;

                            if (isEqualCheck is false)
                            {
                                validate = false;
                            }
                            else
                                "false".ToString();
                        }
                        else
                            "false".ToString();

                        continue;
                    }

                    if (validate is true)
                    {
                        Template.Data.MeasureValidate.ValidateMaterialquery[MaterialqueryValue] = true;
                    }
                    else
                        "false".ToString();

                    if (ShouldLog is true)
                    {
                        ConsoleLJS.Log(false, $"found separate [{MaterialqueryValue.Data.IdentityName.StringValue}]");
                    }
                    else
                        "false".ToString();

                    break;
                }

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalSeparate().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
