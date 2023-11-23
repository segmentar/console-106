using Core;

namespace Core
{
    using System;

    public partial class ScopeTemplate
    {
        public ScopeTemplateData Data;

        public ScopeTemplate
(
ScopeMeasureWait measureWait,
ScopeMeasureFileArray measureFileArray,
ScopeMeasureFile measureFile,
ScopeMeasureFlag measureFlag,
ScopeMeasureValue measureValue,
ScopeMeasureQuery measureQuery,
ScopeMeasureValidate measureValidate,
ScopeMeasureInstruction measureInstruction,
ScopeMeasureFolder measureFolder
)
        {
            ScopeTemplateData data;

            data = new ScopeTemplateData();

            data.MeasureWait = measureWait;

            data.MeasureFileArray = measureFileArray;

            data.MeasureFile = measureFile;

            data.MeasureFlag = measureFlag;

            data.MeasureValue = measureValue;

            data.MeasureQuery = measureQuery;

            data.MeasureValidate = measureValidate;

            data.MeasureInstruction = measureInstruction;

            data.MeasureFolder = measureFolder;

            this.Data = data;

            return;
        }

        ~ScopeTemplate()
        {
            return;
        }
    }
}
