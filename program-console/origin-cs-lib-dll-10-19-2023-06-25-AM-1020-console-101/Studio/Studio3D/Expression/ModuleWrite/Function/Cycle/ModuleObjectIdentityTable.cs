using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleWriteIO
    {
        public static ExpressionModuleWrite ModuleObjectIdentityTable(ExpressionModuleWrite module, Object[] array_OBJECT)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Expression.WriterEncoding, true);

            using (binaryWriter)
            {
                var ObjectIdentity__START = new Int32[module.ExpressionLength];

                var ObjectIdentity__END = new Int32[module.ExpressionLength];

                var indexer = 0;

                var array = Expression.ExpressionReflectSetSurface(array_OBJECT);

                foreach (Byte[] byteArray in array)
                {
                    var Convert_TEMP = Convert.ToInt32(binaryWriter.BaseStream.Position);

                    ObjectIdentity__START[indexer] = Convert_TEMP;

                    binaryWriter.Write(byteArray);

                    var Convert_POSITION = Convert.ToInt32(binaryWriter.BaseStream.Position);

                    ObjectIdentity__END[indexer] = Convert_POSITION;

                    indexer = indexer + 1;

                    continue;
                }

                binaryWriter.Close();

                binaryWriter.Dispose();

                module.IdentityObjectStartAddressArray = ObjectIdentity__START;

                module.IdentityObjectEndAddressArray = ObjectIdentity__END;

                module.ObjectIdentityMemoryStream = memoryStream;
            }

            return module;
        }
    }
}
