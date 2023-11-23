using Core;

namespace Core
{/*
  *     `var Entity_BIND` .
  *     
  *     `var separator` .
  *     
  *     `var split` .
  *     
  *     Check's `hasLengthCheck` .
  *     
*/}

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class Primaryfunction
        {
            public static void MaterialgriWhileTertiary()
            {
                var Entity_BIND = new String(CI, 2);

                var Entity_WHITE_SPACE = Convert.ToChar(32);

                var separator = new String[] { Entity_WHITE_SPACE.ToString(), Entity_BIND };

                var split = CompareGridString.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                Boolean hasLengthCheck;

                hasLengthCheck = split.Length.Equals(0) is false;

                if (hasLengthCheck is true)
                {
                    var indexer = 0;

                    while (split.Length.Equals(indexer) is false)
                    {
                        STRZ = split[indexer];

                        var format = STRZ.Trim(CI);

                        split[indexer] = format;

                        indexer = indexer + 1;

                        continue;
                    }
                }
                else
                    "false".ToString();

                Char character;

                character = CI;

                String[] IsolateString__ARRAY;

                IsolateString__ARRAY = split;

                Tuple<Char, String[]> tuple;

                tuple = new Tuple<Char, String[]>(character, IsolateString__ARRAY);

                DictionaryArrayList.Add(tuple);

                return;
            }
        }
    }
}
