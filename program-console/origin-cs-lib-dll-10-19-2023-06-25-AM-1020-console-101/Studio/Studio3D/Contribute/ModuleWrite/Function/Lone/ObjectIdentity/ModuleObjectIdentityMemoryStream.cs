using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct ContributeModuleWriteLone
    {
        public static ContributeModuleWrite ModuleObjectIdentityMemoryStream(ContributeModuleWrite module)
        {
            var list = new ArrayList();

            list.AddRange(module.Third.Function.TupleArrayA);

            list.AddRange(module.Third.Function.TupleArrayB);

            list.AddRange(module.Third.Function.TupleArrayC);

            list.AddRange(module.Third.Function.TupleArrayD);

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Contribute.WriterEncoding, true);

            using (binaryWriter)
            {
                foreach (Tuple<Int32, Int32, Int32, Contribute> item_TUPLE in list)
                {
                    var RegionStart__ITEM = item_TUPLE.Item2;

                    var Contribute_ITEM = item_TUPLE.Item4;

                    binaryWriter.BaseStream.Seek(RegionStart__ITEM, SeekOrigin.Begin);

                    binaryWriter.Write(Contribute_ITEM.ByteArray);

                    continue;
                }

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            module.Streamline.ObjectIdentityMemoryStream = memoryStream;

            return module;
        }
    }
}
