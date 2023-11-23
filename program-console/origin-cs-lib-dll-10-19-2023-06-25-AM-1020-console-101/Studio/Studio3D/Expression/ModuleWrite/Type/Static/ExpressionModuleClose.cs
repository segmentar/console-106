using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        public static void Close(ExpressionModuleWrite module)
        {
            module.HeaderMemoryStream.Close();

            module.HeaderMemoryStream.Dispose();

            module.StringIdentityMemoryStream.Close();

            module.StringIdentityMemoryStream.Dispose();

            module.ObjectIdentityMemoryStream.Close();

            module.ObjectIdentityMemoryStream.Dispose();

            module.MemoryStream.Close();

            module.MemoryStream.Dispose();

            return;
        }   
    }
}
