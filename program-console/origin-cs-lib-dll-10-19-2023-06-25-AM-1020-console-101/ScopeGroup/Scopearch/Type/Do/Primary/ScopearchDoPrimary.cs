using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopearch
    {
        public static void ScopearchPrimaryDo()
        {
            try
            {
                MaterialchainStack = new Stack(Template.Data.MeasureValidate.MaterialchainArrayList);

                MaterialchainStack = new Stack(MaterialchainStack);

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = MaterialchainStack.Count.Equals(0) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var reflect = (Materialchain)(MaterialchainStack.Pop() as Object);

                    MaterialchainValue = reflect;

                    var Log_ENTITY = "log";

                    Boolean shouldLogContagentCheck;

                    shouldLogContagentCheck = MaterialchainValue.Materialinfo.Name.StringValue.Contains(Log_ENTITY) is true;

                    if (shouldLogContagentCheck)
                    {
                        ShouldLog = true;
                    }
                    else
                    {
                        ShouldLog = false;
                    }

                    Expression = Expression.MakeExpressionRootVariation();

                    Position = Template.Data.MeasureFile.PhysicalOffset;

                    Skip = 0;

                    MaterialqueryIsolateArray = MaterialchainValue.MaterialqueryIsolateArray;

                    LinkedList = new LinkedList<Materialquery>(MaterialqueryIsolateArray);

                    LinkedListPointer = 0;

                    ScopearchDoSecondary();

                    continue;

                } while (true);

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalDoPrimary().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
