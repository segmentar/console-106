using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleWriteLone
    {
        public static ContributeModuleWrite ModuleMemoryStreamA(ContributeModuleWrite module, Tuple<Int32, Int32, Int32, Contribute>[] array_TUPLE)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Contribute.WriterEncoding, true);

            using (binaryWriter)
            {
                var position = binaryWriter.BaseStream.Position;

                foreach (Tuple<Int32, Int32, Int32, Contribute> item_TUPLE in array_TUPLE)
                {
                    var Order_ITEM = item_TUPLE.Item1;

                    var RegionStart__ITEM = item_TUPLE.Item2;

                    var RegionEnd__ITEM = item_TUPLE.Item3;

                    var Contribute_ITEM = item_TUPLE.Item4;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Order_ITEM);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(RegionStart__ITEM);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(RegionEnd__ITEM);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Indexer.StringValue);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Ordinal);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Type.StringValue);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Name.StringValue);

                    position = position + Contribute.BoundarySize;

                    binaryWriter.BaseStream.Seek(position, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.Value.StringValue);

                    position = position + Contribute.BoundarySize;

                    continue;
                }

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            module.Streamline.MemoryStreamA = memoryStream;

            return module;
        }
    }
}
