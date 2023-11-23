using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionTen
        {
            public static ICollection FunctionDefaultContainer(Char[] array_OPEN, Char[] array_CLOSE)
            {
                IList listResult = default;

                listResult = new ArrayList();

                foreach (Char value_OPEN in array_OPEN)
                {
                    Tuple<Char, Char, Boolean> tuple;

                    var symmetry = Material.ForgeSymmetryCharacter(value_OPEN);

                    tuple = new Tuple<Char, Char, Boolean>(value_OPEN, symmetry, false);

                    listResult.Add(tuple);

                    continue;
                }

                foreach (Char value_CLOSE in array_CLOSE)
                {
                    Tuple<Char, Char, Boolean> tuple;

                    var symmetry = Material.ForgeSymmetryCharacter(value_CLOSE);

                    tuple = new Tuple<Char, Char, Boolean>(value_CLOSE, symmetry, true);

                    listResult.Add(tuple);

                    continue;
                }

                return listResult;
            }
        }
    }
}
