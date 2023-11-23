using Core;

namespace Core
{/*
  *     Initialize's `EscapeCharacterArray` .
  *     
  *     Initialize's `ResultCharacterArrayList` .
  *     
  *     Initialize's `DictionaryArryList` .
  *     
  *     Initialize's `Data` .
  *     
  *     Initialize's `I` .
  *     
  *     Transfer's control .
  *     
  *     Initialize's `ResultCharacterArray` .
  *     
  *     Initialize's `DictionaryArray` .
  *     
  *     Copie's content(s) to `ResultCharacterArray` .
  *     
  *     Copie's content(s) to `DictionaryArray` .
  *     
  *     Initialize's `StringResult` .
*/
}

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class Primaryfunction
        {
            public static Tuple<String, Tuple<Char, String[]>[]> ForgeTupleArray(String value_STRING, Char[] character_ARRAY)
            {
                Tuple<String, Tuple<Char, String[]>[]> tupleResult = default;

                InputString = value_STRING;

                EscapeCharacterArray = character_ARRAY;

                var InputCharacter__ARRAY = value_STRING.ToCharArray();

                ResultCharacterArrayList = new ArrayList(InputCharacter__ARRAY);

                DictionaryArrayList = new ArrayList();

                Data = InputCharacter__ARRAY;

                I = 0;

                MaterialgridWhilePrimary();

                ResultCharacterArray = new Char[ResultCharacterArrayList.Count];

                DictionaryArray = new Tuple<Char, String[]>[DictionaryArrayList.Count];

                ResultCharacterArrayList.CopyTo(ResultCharacterArray, 0);

                DictionaryArrayList.CopyTo(DictionaryArray, 0);

                StringResult = new String(ResultCharacterArray);

                Tuple<String, Tuple<Char, String[]>[]> ResultTuple__VALUE;

                ResultTuple__VALUE = new Tuple<String, Tuple<Char, String[]>[]>(StringResult, DictionaryArray);

                tupleResult = ResultTuple__VALUE;

                return tupleResult;
            }
        }
    }
}
