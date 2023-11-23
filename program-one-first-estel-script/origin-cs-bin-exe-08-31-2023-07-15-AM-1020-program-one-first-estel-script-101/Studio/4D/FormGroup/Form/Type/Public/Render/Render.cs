using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public void Render()
        {
            Expression expression;

            expression = Expression.MakeExpressionRootVariation();

            expression.InstructionHandler(String.Empty, Data.Runtime.FormLine.LocalLineArray);

            Expression.SaveToCurrentDirectory("sample", expression);

            Expression loadedExpression;

            loadedExpression = Expression.LoadFromCurrentDirectory("sample");
            
            var array = Contribute.ContributeDefaultSetSurface(Data.Runtime.FormLine.GlobalLineArray);

            Host.ProcessContributePreloadEnumerable("sample", array, false);

            Host.ProcessContributePreload("nani", false);

            FormWriteFileZeroTen();

            return;
        }
    }
}
