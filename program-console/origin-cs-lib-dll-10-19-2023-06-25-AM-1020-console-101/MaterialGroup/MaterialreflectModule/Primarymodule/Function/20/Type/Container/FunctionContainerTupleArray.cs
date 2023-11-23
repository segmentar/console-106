using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class FunctionTwenty
        {
            public static ArrayList FunctionTupleArrayContainer(String value_STRING, Char[] array_CHARACTER)
            {
                ArrayList listResult = default;

                listResult = new ArrayList();

                var enumerator = array_CHARACTER.GetEnumerator();

                do
                {
                    if (enumerator.MoveNext() is false)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    Char reflectCharacter;

                    reflectCharacter = (Char)(enumerator.Current as Object);

                    var Entity_WHITE_SPACE = Convert.ToChar(32);

                    var Entity_LINE_FEED = Convert.ToChar(10);

                    var Entity_CARRIAGE_RETURN = Convert.ToChar(13);

                    var Entity_NEW_LINE = String.Concat(Entity_CARRIAGE_RETURN, Entity_LINE_FEED);

                    var separator = new String[] { Entity_WHITE_SPACE.ToString(), Entity_NEW_LINE };

                    var split = value_STRING.Split(separator, StringSplitOptions.None);

                    var list = new ArrayList();

                    foreach (String splitValue in split)
                    {
                        var Entity_BIND = new String(reflectCharacter, 2);

                        var position = splitValue.IndexOf(Entity_BIND);

                        var total = (position + Entity_BIND.Length);

                        var start = total;

                        Boolean shouldContinueCheck;

                        shouldContinueCheck = position.Equals(-1) is true;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var aoth = splitValue.Length;

                        var difference = (aoth - start);

                        var count = difference;

                        var sub = splitValue.Substring(total, count);

                        list.Add(sub);

                        continue;
                    }

                    var array = (String[])(list.ToArray(typeof(String)) as Array);

                    Tuple<Char, String[]> tuple;

                    tuple = new Tuple<Char, String[]>(reflectCharacter, array);

                    listResult.Add(tuple);

                    continue;

                } while (true);

                return listResult;
            }
        }
    }
}
