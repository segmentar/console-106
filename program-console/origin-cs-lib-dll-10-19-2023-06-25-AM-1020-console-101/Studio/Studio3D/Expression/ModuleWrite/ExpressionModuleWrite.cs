using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleWrite
    {
        public Expression Expression;

        public Expression[] ExpressionArray;

        public Object[] ExpressionObjectArray;

        public Int32 ExpressionLength;

        public MemoryStream HeaderMemoryStream;

        public MemoryStream StringIdentityMemoryStream;

        public Int32[] IdentityObjectStartAddressArray;

        public Int32[] IdentityObjectEndAddressArray;

        public MemoryStream ObjectIdentityMemoryStream;

        public MemoryStream MemoryStream;

        public ExpressionModuleFirst First;

        public ExpressionModuleSecond Second;
        
        public ExpressionModuleThird Third;
        
        public ExpressionModuleFourth Fourth;
    }
}
