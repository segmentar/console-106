using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public static IList<Byte[]> ExpressionReflectSet(Object[] array_OBJECT)
        {
            ICollection<Byte[]> collectionResult = default;

            collectionResult = new Collection<Byte[]>();

            foreach (Object item_OBJECT in array_OBJECT)
            {
                Byte[] byteArray;

                byteArray = new Byte[0];

                Boolean isDefaultCheck;

                isDefaultCheck = (item_OBJECT == default) is true;

                if (isDefaultCheck is true)
                {
                    goto bypass;
                }
                else
                    "false".ToString();

                if (item_OBJECT is String)
                {
                    var reflect = (String)(item_OBJECT as Object);

                    var array = WriterEncoding.GetBytes(reflect);

                    Array.Resize(ref byteArray, array.Length);

                    array.CopyTo(byteArray, 0);

                    goto bypass;
                }
                else
                    "false".ToString();

                if (item_OBJECT is Int32)
                {
                    var reflect = (Int32)(item_OBJECT as Object);

                    var array = BitConverter.GetBytes(reflect);

                    Array.Resize(ref byteArray, array.Length);

                    array.CopyTo(byteArray, 0);

                    goto bypass;
                }
                else
                    "false".ToString();

                if (item_OBJECT is UInt32)
                {
                    var reflect = (UInt32)(item_OBJECT as Object);

                    var array = BitConverter.GetBytes(reflect);

                    Array.Resize(ref byteArray, array.Length);

                    array.CopyTo(byteArray, 0);

                    goto bypass;
                }
                else
                    "false".ToString();
                
            bypass:
                {
                    collectionResult.Add(byteArray);
                }

                continue;
            }

            return new List<Byte[]>(collectionResult);
        }
    }
}
