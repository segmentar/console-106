using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class FunctionThirty
        {
            public static ArrayList FunctionTupleArrayContainer(Char[] array_CHARACTER, Tuple<Char, String[]>[] array_HOLE, Tuple<Char, String[]>[] array_BIND)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                foreach (Char character in array_CHARACTER)
                {
                    ArrayList arrayListHole, arrayListBind;

                    arrayListHole = new ArrayList();

                    arrayListBind = new ArrayList();

                    foreach (Tuple<Char, String[]> item_TUPLE in array_BIND)
                    {
                        var reflect_entry__CHARACTER = item_TUPLE.Item1;

                        var reflect_entry__ARRAY = item_TUPLE.Item2;

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = reflect_entry__CHARACTER.Equals(character) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        foreach (String item_STRING in reflect_entry__ARRAY)
                        {
                            arrayListHole.Add(item_STRING);

                            continue;
                        }

                        continue;
                    }

                    foreach (Tuple<Char, String[]> item_TUPLE in array_HOLE)
                    {
                        var reflect_entry__CHARACTER = item_TUPLE.Item1;

                        var reflect_entry__ARRAY = item_TUPLE.Item2;

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = reflect_entry__CHARACTER.Equals(character) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        foreach (String item_STRING in reflect_entry__ARRAY)
                        {
                            arrayListBind.Add(item_STRING);

                            continue;
                        }

                        continue;
                    }

                    var item_entry_reflect__HOLE = (String[])(arrayListHole.ToArray(typeof(String)) as Array);

                    var item_entry_reflect__BIND = (String[])(arrayListBind.ToArray(typeof(String)) as Array);

                    Tuple<Char, String[], String[]> tuple;

                    tuple = new Tuple<Char, String[], String[]>(character, item_entry_reflect__HOLE, item_entry_reflect__BIND);

                    listResult.Add(tuple);

                    continue;
                }

                return listResult;
            }
        }
    }
}
