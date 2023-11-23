using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static ExpressionModuleWrite ExpressionModuleDefault(Expression item_EXPRESSION)
        {
            ExpressionModuleWrite module;

            module = new ExpressionModuleWrite();

            var array__EXPRESSION = Expression.ExpressionAllSetSurface(item_EXPRESSION);

            var array__OBJECT = Expression.ExpressionObjectSetSurface(array__EXPRESSION);

            var symmetry = (array__EXPRESSION.Length + array__OBJECT.Length);

            var divide = (symmetry / 2);

            module.Expression = item_EXPRESSION;

            module.ExpressionArray = array__EXPRESSION;

            module.ExpressionObjectArray = array__OBJECT;

            module.ExpressionLength = divide;

            module = ExpressionModuleWriteIO.ModuleAddressTable(module);
 
            module = ExpressionModuleOne(module);

            module = ExpressionModuleTwo(module);

            module = ExpressionModuleWriteIO.ModuleObjectIdentityTable(module, module.ExpressionObjectArray);

            module = ExpressionModuleThree(module);

            module = ExpressionModuleFour(module);

            module = ExpressionModuleWriteIO.ModuleStringIdentityTable(module, module.Fourth.Function.TupleArray);

            module = ExpressionModuleWriteIO.ModuleWriteBinary(module);

            return module;
        }
    }
}
