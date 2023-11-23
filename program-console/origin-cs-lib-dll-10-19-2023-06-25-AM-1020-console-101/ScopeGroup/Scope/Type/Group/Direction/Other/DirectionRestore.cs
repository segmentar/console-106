using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void DirectionRestore(Boolean answer_UNPAUSE_should)
        {
            MeasureWait = Template.Data.MeasureWait;

            MeasureFileArray = Template.Data.MeasureFileArray;

            MeasureFile = Template.Data.MeasureFile;

            MeasureFlag = Template.Data.MeasureFlag;

            MeasureValue = Template.Data.MeasureValue;

            MeasureQuery = Template.Data.MeasureQuery;

            if (answer_UNPAUSE_should is true)
            {
                MeasureWait.IsPause = false;
            }
            else
                "false".ToString();

            return;
        }
    }
}
