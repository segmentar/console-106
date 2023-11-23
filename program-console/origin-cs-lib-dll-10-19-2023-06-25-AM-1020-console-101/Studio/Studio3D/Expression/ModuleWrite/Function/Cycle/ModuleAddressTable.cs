using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleWriteIO
    {
        public static ExpressionModuleWrite ModuleAddressTable(ExpressionModuleWrite module)
        {
            var StringIdentityTableAddress____ITEM = 0;

            StringIdentityTableAddress____ITEM = StringIdentityTableAddress____ITEM + Expression.BoundaryStart;

            var ObjectIdentityTableAddress____ITEM = 0;

            ObjectIdentityTableAddress____ITEM = ObjectIdentityTableAddress____ITEM + Expression.BoundaryStart;

            ObjectIdentityTableAddress____ITEM = ObjectIdentityTableAddress____ITEM + (Expression.BoundarySize * module.ExpressionLength);

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Expression.WriterEncoding, true);

            using (binaryWriter)
            {
                binaryWriter.Write(module.ExpressionLength);

                binaryWriter.Write(StringIdentityTableAddress____ITEM);

                binaryWriter.Write(ObjectIdentityTableAddress____ITEM);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            module.HeaderMemoryStream = memoryStream;

            return module;
        }
    }
}

