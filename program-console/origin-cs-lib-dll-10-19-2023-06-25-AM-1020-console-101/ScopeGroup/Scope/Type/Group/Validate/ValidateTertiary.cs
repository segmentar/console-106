using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ValidateTertiary()
        {
            if (MeasureFlag.ScopeShutdownFlag is false)
            {
                Scopearch.Reset();

                /*foreach (Materialchain materialchain in MeasureValidate.MaterialchainArrayList)
                {
                    MeasureValidate.Expression = Expression.MakeExpressionRootVariation();

                    MeasureValidate.Position = MeasureFile.PhysicalOffset;

                    MeasureValidate.Skip = 0;

                    MeasureValidate.Array = materialchain.MaterialqueryIsolateArray;

                    MeasureValidate.LinkedList = new LinkedList<Materialquery>(MeasureValidate.Array);

                    MeasureValidate.LinkedListPointer = 0;

                    do
                    {
                        Boolean shouldBreakCheck;

                        shouldBreakCheck = MeasureValidate.LinkedList.Count.Equals(MeasureValidate.LinkedListPointer) is true;

                        if (shouldBreakCheck is true)
                        {
                            break;
                        }
                        else
                            "false".ToString();

                        MeasureValidate.Value = MeasureValidate.Array[MeasureValidate.LinkedListPointer];

                        var reflect = MeasureValidate.LinkedList.Find(MeasureValidate.Value);

                        MeasureValidate.LinkedListNode = reflect;

                        ProcessRequire();

                        ProcessAny();

                        ProcessSeparate();

                        ProcessSentence();

                        MeasureValidate.LinkedListPointer = MeasureValidate.LinkedListPointer + 1;

                        continue;

                    } while (true);

                    continue;
                }*/
            }
            else
                "false".ToString();

            return;
        }
    }
}
