using Core;

namespace Core
{
    using System;

    public partial class Scopearch
    {
        public static void ScopearchDoSecondary()
        {
            try
            {
                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = LinkedList.Count.Equals(LinkedListPointer) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    MaterialqueryValue = MaterialqueryIsolateArray[LinkedListPointer];

                    var reflect = LinkedList.Find(MaterialqueryValue);

                    LinkedListNode = reflect;

                    Require();

                    Option();

                    Any();

                    Separate();

                    Sentence();

                    Paragraph();

                    LinkedListPointer = LinkedListPointer + 1;

                    continue;

                } while (true);

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalDoSecondary().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
