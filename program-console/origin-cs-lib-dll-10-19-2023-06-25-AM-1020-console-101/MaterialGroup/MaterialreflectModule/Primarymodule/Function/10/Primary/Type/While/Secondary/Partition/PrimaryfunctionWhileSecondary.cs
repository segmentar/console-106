using Core;

namespace Core
{/*
  *     Initialize's `BlackGridArray` .
  *     
  *     Initialize's `WhiteGridArray` .
  *     
  *     Initialize's `CompareGridArray` .
  *     
  *     Enter's a loop cycle .
  *     
  *     Breakcheck .
  *     
  *     Initialize's `CJ` .
  *     
  *     Check's `BlackGridIs___ANSWER` .
  *     
  *     Check's `isEqualCheck` .
  *     
  *     Check's `WhiteGridIs___ANSWER` . 
  *     
  *     Initialize's `CK` .
  *     
  *     Initialize's `CL` .
  *     
  *     `var total` .
  *     
  *     `var divide`
  *     
  *     `var convert`
  *    
  *     Check's `CompareGridIs___ANSWER` .
  *     
  *     Check's `isWhiteSpaceCheck` .
  *     
  *     Initialize's `BlackGridString` .
  *     
  *     Initialize's `WhiteGridString` .
  *     
  *     Initailize's `CompareGridString` .
  *     
  *     .....
  *     
  *     それ　は　‘BlackGridArray‘ を　イニシャライズ　。
  * 
  *     それ　は　‘WhiteGridArray‘ を　イニシャライズ　。
  *     
  *     それ　は　‘CompareGridArray‘ を　イニシャライズ　。
  *     
  *     .....
  *     
  *     يبداُ `BlackGridArray` .
  *     
  *     
  *     ٌيبدا `WhiteGridArray` .
  * 
*/
}

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class Primaryfunction
        {
            public static void MaterialgriWhileSecondary()
            {
                BlackGridArray = new Char[Data.Length];

                WhiteGridArray = new Char[Data.Length];

                CompareGridArray = new Char[Data.Length];

                while (true)
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = Data.Length.Equals(J) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    CJ = Data[J];

                    var Entity_WHITE_SPACE = Convert.ToChar(32);

                    if (BlackGridIs___ANSWER)
                    {
                        BlackGridArray[J] = CJ;
                    }
                    else
                    {
                        BlackGridArray[J] = Entity_WHITE_SPACE;
                    }

                    Boolean isEqualCheck;

                    isEqualCheck = CI.Equals(CJ) is true;

                    if (isEqualCheck is true)
                    {
                        BlackGridIs___ANSWER = BlackGridIs___ANSWER.Equals(false);

                        WhiteGirdIs___ANSWER = WhiteGirdIs___ANSWER.Equals(false);
                    }
                    else
                        "false".ToString();

                    if (WhiteGirdIs___ANSWER)
                    {
                        WhiteGridArray[J] = CJ;
                    }
                    else
                    {
                        WhiteGridArray[J] = Entity_WHITE_SPACE;
                    }

                    CK = BlackGridArray[J];

                    CL = WhiteGridArray[J];

                    var total = (CK + CL);

                    var divide = (total / 2);

                    var convert = Convert.ToChar(divide);

                    CompareGridIs___ANSWER = CK.Equals(CL) is true;

                    if (CompareGridIs___ANSWER)
                    {
                        CompareGridArray[J] = convert;
                    }
                    else
                    {
                        CompareGridArray[J] = CI;
                    }

                    var boolean_match_WHITE_SPACE_is = true;

                    boolean_match_WHITE_SPACE_is = boolean_match_WHITE_SPACE_is && CK.Equals(CL) is true;

                    boolean_match_WHITE_SPACE_is = boolean_match_WHITE_SPACE_is && divide.Equals(Entity_WHITE_SPACE) is true;

                    Boolean isWhiteSpaceCheck;

                    isWhiteSpaceCheck = boolean_match_WHITE_SPACE_is is true;

                    if (isWhiteSpaceCheck is false)
                    {
                        ResultCharacterArrayList[J] = Entity_WHITE_SPACE;
                    }
                    else
                        "false".ToString();

                    J = J + 1;

                    continue;
                }

                BlackGridString = new String(BlackGridArray);

                WhiteGridString = new String(WhiteGridArray);

                CompareGridString = new String(CompareGridArray);

                return;
            }
        }
    }
}
