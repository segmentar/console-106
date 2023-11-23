using Core;

namespace Core
{
    using System;
    
    using System.Collections;

    public partial struct MaterialreflectTertiarymodule
    {
        public partial class FunctionTen
        {
            public static ICollection FunctionDefaultContainer(SecondarymoduleFunctionEightyPort[] array_FUNCTION)
            {
                IList listResult = default;

                listResult = new ArrayList();

                foreach (SecondarymoduleFunctionEightyPort value_FUNCTION in array_FUNCTION)
                {
                    MaterialqueryMeasure measure;

                    measure = new MaterialqueryMeasure();

                    measure.ChildArray = new Materialquery[0];

                    Materialquery materialQuery;

                    materialQuery = new Materialquery
(
measure: measure,
initialStringValue: value_FUNCTION.InitialStringValue,
subsequentStringValue: value_FUNCTION.SubsequentStringValue,
segmentArray: value_FUNCTION.SegmentArray,
identityName: value_FUNCTION.IdentityName,
virtualName: value_FUNCTION.VirtualName,
stickyLeft: value_FUNCTION.StickyLeft,
stickyRight: value_FUNCTION.StickyRight,
layer: value_FUNCTION.Layer,
rank: value_FUNCTION.Rank,
leftPosition: value_FUNCTION.LeftPosition,
leftCharacter: value_FUNCTION.LeftCharacter,
leftSymmetryCharacter: value_FUNCTION.LeftSymmetryCharacter,
leftSymmetryHas: value_FUNCTION.LeftSymmetryHas,
rightPosition: value_FUNCTION.RightPosition,
rightCharacter: value_FUNCTION.RightCharacter,
rightSymmetryCharacter: value_FUNCTION.RightSymmetryCharacter,
rightSymmetryHas: value_FUNCTION.RightSymmetryHas
);
                    Tuple<Materialquery, SecondarymoduleFunctionSeventyPort> tuple;

                    tuple = new Tuple<Materialquery, SecondarymoduleFunctionSeventyPort>(materialQuery, value_FUNCTION.Origin);

                    listResult.Add(tuple);

                    continue;
                }

                return listResult;
            }
        }
    }
}
