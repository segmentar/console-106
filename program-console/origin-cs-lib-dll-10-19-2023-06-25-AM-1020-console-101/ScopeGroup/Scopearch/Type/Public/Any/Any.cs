using Core;

namespace Core
{
    using System;

    public partial class Scopearch
    {
        public static void Any()
        {
            try
            {
                Boolean shouldReturnContiniousCheck;

                shouldReturnContiniousCheck = MaterialqueryValue.Data.Runtime.QueryType.Equals(MaterialqueryCode.QueryType.Any) is false;

                if (shouldReturnContiniousCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var start = Position;// (MeasureValidate.Position + MeasureValidate.Skip);

                var sub = Template.Data.MeasureFileArray.Text.StringValue.Substring(start);

                var Entity_LINE_FEED = Convert.ToChar(10);

                var Entity_CARRIAGE_RETURN = Convert.ToChar(13);

                var Entity_WHITE_SPACE = Convert.ToChar(32);

                var separator = new String[3] {

                Entity_LINE_FEED.ToString(),
                Entity_CARRIAGE_RETURN.ToString(),
                Entity_WHITE_SPACE.ToString()
            };

                Boolean hasPreviousCheck, hasNextCheck;

                hasPreviousCheck = (LinkedListPointer < 0) is false;

                hasNextCheck = (LinkedListPointer < LinkedList.Count) is true;

                if (hasPreviousCheck is true)
                {
                    var aoth = separator.Length;

                    var zee = (aoth + 1);

                    Array.Resize(ref separator, zee);

                    var roth = (zee - 1);

                    separator[roth] = LinkedListNode.Previous.Value.Data.SubsequentStringValue.StringValue;
                }
                else
                    "false".ToString();

                if (hasNextCheck is true)
                {
                    var aoth = separator.Length;

                    var zee = (aoth + 1);

                    Array.Resize(ref separator, zee);

                    var roth = (zee - 1);

                    separator[roth] = LinkedListNode.Next.Value.Data.SubsequentStringValue.StringValue;
                }
                else
                    "false".ToString();

                var split = sub.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                Boolean hasLengthCheck;

                hasLengthCheck = split.Length.Equals(0) is false;

                shouldReturnContiniousCheck = hasLengthCheck is false;

                if (shouldReturnContiniousCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var first = split[0];

                Expression.IView(Expression);

                Expression.IUnlock(LinkedListNode.Value.Data.VirtualName.StringValue);

                Expression.ILock(first);

                Template.Data.MeasureValidate.ValidateMaterialquery[MaterialqueryValue] = true;

                if (ShouldLog is true)
                {
                    ConsoleLJS.Log(false, "found any");
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalAny().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
