using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleWriteIO
    {
        public static ExpressionModuleWrite ModuleWriteBinary(ExpressionModuleWrite module)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Expression.WriterEncoding, true);

            using (binaryWriter)
            {
                binaryWriter.Write(module.HeaderMemoryStream.ToArray());

                binaryWriter.BaseStream.Seek(Expression.BoundaryStart, SeekOrigin.Begin);

                binaryWriter.Write(module.StringIdentityMemoryStream.ToArray());

                binaryWriter.Write(module.ObjectIdentityMemoryStream.ToArray());

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            module.MemoryStream = memoryStream;

            return module;
        }
    }
}
