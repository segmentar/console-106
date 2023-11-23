using Core;

namespace Core
{
    using System;

    public partial class ScopeTemplate
    {
        public static ScopeTemplate ForgeScopeTemplate()
        {
            ScopeTemplate scopeTemplateResult = default;

            ScopeTemplate scopeTemplate;

            scopeTemplate = new ScopeTemplate
(
Scope.MeasureWait,
Scope.MeasureFileArray,
Scope.MeasureFile,
Scope.MeasureFlag,
Scope.MeasureValue,
Scope.MeasureQuery,
Scope.MeasureValidate,
Scope.MeasureInstruction,
Scope.MeasureFolder
);

            scopeTemplateResult = scopeTemplate;

            return scopeTemplateResult;
        }
    }
}
