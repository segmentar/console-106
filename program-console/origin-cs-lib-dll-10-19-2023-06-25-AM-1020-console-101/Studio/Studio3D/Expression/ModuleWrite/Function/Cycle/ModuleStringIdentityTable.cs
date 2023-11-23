using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleWriteIO
    {
        public static ExpressionModuleWrite ModuleStringIdentityTable(ExpressionModuleWrite module, Tuple<Int32, Int32, Int32, Int32, String>[] array_TUPLE)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Expression.WriterEncoding, true);

            using (binaryWriter)
            {
                var position = binaryWriter.BaseStream.Position;

                foreach (Tuple<Int32, Int32, Int32, Int32, String> item_TUPLE in array_TUPLE)
                {
                    var Ordinal_ITEM = item_TUPLE.Item1;

                    var Relate_ITEM = item_TUPLE.Item2;

                    var RegionStartAddress___ITEM = item_TUPLE.Item3;

                    var RegionEndAddress___ITEM = item_TUPLE.Item4;

                    var StringIdentity__ITEM = item_TUPLE.Item5;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Ordinal_ITEM);

                    binaryWriter.Write(Relate_ITEM);

                    binaryWriter.Write(RegionStartAddress___ITEM);

                    binaryWriter.Write(RegionEndAddress___ITEM);

                    binaryWriter.Write(StringIdentity__ITEM);

                    position = position + Expression.BoundarySize;

                    continue;
                }

                binaryWriter.BaseStream.SetLength(position);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            module.StringIdentityMemoryStream = memoryStream;

            return module;
        }
    }
}

