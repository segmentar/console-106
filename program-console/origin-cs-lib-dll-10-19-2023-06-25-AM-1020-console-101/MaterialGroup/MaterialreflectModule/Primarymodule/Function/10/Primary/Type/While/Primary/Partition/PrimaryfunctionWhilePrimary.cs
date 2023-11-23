using Core;

namespace Core
{/*
  *     Initialize's `J` .
  *     
  *     Breakcheck .
  *     
  *     Initialize's `CI` .
  *     
  *     Transfer's control .
  *     
  *     Transfer's control .
  *     
  *     Increment's `I` .
*/}

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        public partial class Primaryfunction
        {
            public static void MaterialgridWhilePrimary()
            {
                while (true)
                {
                    J = 0;

                    Boolean shouldBreakCheck;

                    shouldBreakCheck = EscapeCharacterArray.Length.Equals(I) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    CI = EscapeCharacterArray[I];

                    MaterialgriWhileSecondary();

                    MaterialgriWhileTertiary();

                    I = I + 1;

                    continue;
                }

                return;
            }
        }
    }
}
