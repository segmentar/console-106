using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scope
    {
        public static String SolidDictionary(IDictionary Dictionary_VALUE, Int32 Count_VALUE)
        {      
            String stringResult = default;

            var result = String.Empty;

            result = result + SolidDictionaryCount(Count_VALUE);

            result = result + SolidDictionaryPair(Dictionary_VALUE, Count_VALUE);

            stringResult = result;
            
            return stringResult;
        }
    }
}
