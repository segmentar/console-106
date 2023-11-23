using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void TransactionLinkedList
(
String Onefirst_VALUE,
String Twosecond_VALUE,
String Threethird_VALUE,
String Fourfourth_VALUE, 
String Fivefifth_VALUE,
String Sixsixth_VALUE,
String Sevenseventh_VALUE,
String Eighteighth_VALUE,
String Nineninth_VALUE
)
        {
            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[0] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Onefirst_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[1] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Twosecond_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[2] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Threethird_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[3] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Fourfourth_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[4] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Fivefifth_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[5] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Sixsixth_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[6] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Sevenseventh_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[7] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Eighteighth_VALUE;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[8] as ScopeDisplay).Controls[0] as ScopeTextBox).TextProperty = Nineninth_VALUE;

            var array = new String[9];

            array[0] = Onefirst_VALUE;

            array[1] = Twosecond_VALUE;

            array[2] = Threethird_VALUE;

            array[3] = Fourfourth_VALUE;

            array[4] = Fivefifth_VALUE;

            array[5] = Sixsixth_VALUE;

            array[6] = Sevenseventh_VALUE;

            array[7] = Eighteighth_VALUE;

            array[8] = Nineninth_VALUE;

            ScopeTransaction scopeTransaction;

            scopeTransaction = new ScopeTransaction(MeasureFileArray.Filename.StringValue, array);

            AdvanceLinkedList(scopeTransaction);

            return;
        }
    }
}
