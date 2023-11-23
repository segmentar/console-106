using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public static Expression Load(String item_PATH)
        {
            Expression expressionResult = default;

            FileStream fileStream;

            fileStream = File.OpenRead(item_PATH);

            using (fileStream)
            {
                ExpressionModuleRead expressionModuleRead = ExpressionModuleRead.ExpressionModuleAction(fileStream, true);

                expressionResult = expressionModuleRead.Expression;

                fileStream.Close();

                fileStream.Dispose();
            }

            return expressionResult;
        }
    }
}
