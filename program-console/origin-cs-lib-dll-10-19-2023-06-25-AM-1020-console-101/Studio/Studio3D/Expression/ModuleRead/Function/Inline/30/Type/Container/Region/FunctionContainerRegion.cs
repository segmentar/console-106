using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFunctionThirty
        {
            public static ArrayList FunctionRegionContainer(FileStream item__FILE_STREAM, Tuple<Int32, Int32, Int32, Int32, String>[] array_TUPLE)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(item__FILE_STREAM, Expression.ReaderEncoding, true);

                using (binaryReader)
                {
                    foreach (Tuple<Int32, Int32, Int32, Int32, String> item_TUPLE in array_TUPLE)
                    {
                        var Ordinal_ITEM = item_TUPLE.Item1;

                        var Relate_ITEM = item_TUPLE.Item2;

                        var RegionStartAddress___ITEM = item_TUPLE.Item3;

                        var RegionEndAddress___ITEM = item_TUPLE.Item4;

                        var StringIdentity__ITEM = item_TUPLE.Item5;

                        var difference = (RegionEndAddress___ITEM - RegionStartAddress___ITEM);

                        binaryReader.BaseStream.Seek(RegionStartAddress___ITEM, SeekOrigin.Begin);

                        var array = binaryReader.ReadBytes(difference);

                        Tuple<Int32, Int32, Int32, Int32, String, Byte[]> tuple;

                        tuple = new Tuple<Int32, Int32, Int32, Int32, String, Byte[]>(Ordinal_ITEM, Relate_ITEM, RegionStartAddress___ITEM, RegionEndAddress___ITEM, StringIdentity__ITEM, array);

                        listResult.Add(tuple);

                        continue;
                    }

                    binaryReader.Close();

                    binaryReader.Dispose();
                }

                return listResult;
            }
        }
    }
}
