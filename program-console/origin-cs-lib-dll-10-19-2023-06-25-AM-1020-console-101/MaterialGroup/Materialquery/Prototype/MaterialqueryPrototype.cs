using Core;

namespace Core
{
    using System;

    public partial class Materialquery
    {
        public Materialquery
(
MaterialqueryMeasure measure,
MaterialStringSafe initialStringValue,
MaterialStringSafe subsequentStringValue,
MaterialStringArraySafe segmentArray,
MaterialStringSafe identityName,
MaterialStringSafe virtualName,
Boolean stickyLeft,
Boolean stickyRight,
Int32 layer,
Int32 rank,
Int32 leftPosition,
MaterialCharacterSafe leftCharacter,
MaterialCharacterSafe leftSymmetryCharacter,
Boolean leftSymmetryHas,
Int32 rightPosition,
MaterialCharacterSafe rightCharacter,
MaterialCharacterSafe rightSymmetryCharacter,
Boolean rightSymmetryHas
)
        {
            MaterialqueryData data;

            data = new MaterialqueryData();

            data.Measure = measure;

            data.InitialStringValue = initialStringValue;

            data.SubsequentStringValue = subsequentStringValue;

            data.SegmentArray = segmentArray;

            data.IdentityName = identityName;

            data.VirtualName = virtualName;

            data.StickyLeft = stickyLeft;

            data.StickyRight = stickyRight;

            data.Layer = layer;

            data.Rank = rank;

            data.LeftPosition = leftPosition;

            data.LeftCharacter = leftCharacter;

            data.LeftSymmetryCharacter = leftSymmetryCharacter;

            data.LeftSymmetryHas = leftSymmetryHas;

            data.RightPosition = rightPosition;

            data.RightCharacter = rightCharacter;

            data.RightSymmetryCharacter = rightSymmetryCharacter;

            data.RightSymmetryHas = rightSymmetryHas;

            this.Data = data;

            return;
        }
    }
}
