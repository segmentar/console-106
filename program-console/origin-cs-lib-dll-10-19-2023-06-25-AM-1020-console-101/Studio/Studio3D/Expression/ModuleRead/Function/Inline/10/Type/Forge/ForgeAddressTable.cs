using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ExpressionModuleRead
    {
        public partial class ExpressionModuleFunctionTen
        {
            public static Tuple<Int32, Int32, Int32> ForgeAddressTable(FileStream item__FILE_STREAM)
            {
                Tuple<Int32, Int32, Int32> tupleResult;

                BinaryReader binaryReader;

                binaryReader = new BinaryReader(item__FILE_STREAM, Expression.ReaderEncoding, true);

                using (binaryReader)
                {
                    var ExpressionCount__ITEM = binaryReader.ReadInt32();

                    var StringIdentityTableAddress____ITEM = binaryReader.ReadInt32();

                    var ObjectIdentityTableAddress____ITEM = binaryReader.ReadInt32();

                    Tuple<Int32, Int32, Int32> tuple;

                    tuple = new Tuple<Int32, Int32, Int32>(ExpressionCount__ITEM, StringIdentityTableAddress____ITEM, ObjectIdentityTableAddress____ITEM);

                    tupleResult = tuple;

                    binaryReader.Close();

                    binaryReader.Dispose();
                }

                return tupleResult;
            }
        }
    }
}
