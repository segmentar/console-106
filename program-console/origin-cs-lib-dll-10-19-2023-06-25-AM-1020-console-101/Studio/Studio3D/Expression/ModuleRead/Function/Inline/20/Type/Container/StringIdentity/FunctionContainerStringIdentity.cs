using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFunctionTwenty
        {
            public static ArrayList FunctionStringIdentityContainer(FileStream item__FILE_STREAM, Tuple<Int32, Int32, Int32> item_TUPLE)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                var ExpressionLength__ITEM = item_TUPLE.Item1;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(item__FILE_STREAM, Expression.ReaderEncoding, true);

                using (binaryReader)
                {
                    var position = Expression.BoundaryStart;

                    var indexer = 0;

                    do
                    {
                        Boolean shouldBreakCheck;

                        shouldBreakCheck = ExpressionLength__ITEM.Equals(indexer) is true;

                        if (shouldBreakCheck is true)
                        {
                            break;
                        }
                        else
                            "false".ToString();

                        binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);

                        var Ordinal_ITEM = binaryReader.ReadInt32();

                        var Relate_ITEM = binaryReader.ReadInt32();

                        var RegionStartAddress___ITEM = binaryReader.ReadInt32();

                        var RegionEndAddress___ITEM = binaryReader.ReadInt32();

                        var StringIdentity__ITEM = binaryReader.ReadString();

                        Tuple<Int32, Int32, Int32, Int32, String> tuple;

                        tuple = new Tuple<Int32, Int32, Int32, Int32, String>(Ordinal_ITEM, Relate_ITEM, RegionStartAddress___ITEM, RegionEndAddress___ITEM, StringIdentity__ITEM);

                        listResult.Add(tuple);

                        position = position + Expression.BoundarySize;

                        indexer = indexer + 1;

                        continue;

                    } while (true);

                    binaryReader.Close();

                    binaryReader.Dispose();
                }

                return listResult;
            }
        }
    }
}
