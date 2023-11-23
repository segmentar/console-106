using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleRead
    {
        public static ExpressionModuleRead ExpressionModuleDefault(FileStream item__FILE_STREAM)
        {
            ExpressionModuleRead module;

            module = new ExpressionModuleRead();

            module.FileStream = item__FILE_STREAM;

            module.Expression = Expression.MakeExpressionEmptyVariation();

            module = ExpressionModuleOne(module);

            module = ExpressionModuleTwo(module);

            module = ExpressionModuleThree(module);

            module = ExpressionModuleFour(module);

            module = ExpressionModuleReadIO.ModuleOwner(module, module.Fourth.Function.TupleArray);

            return module;
        }
    }
}
