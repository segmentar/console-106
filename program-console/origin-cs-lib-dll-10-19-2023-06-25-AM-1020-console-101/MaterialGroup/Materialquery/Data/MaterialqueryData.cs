using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryData
    {
        public MaterialqueryMeasure Measure;

        public MaterialqueryRuntime Runtime;

        public MaterialStringSafe InitialStringValue;

        public MaterialStringSafe SubsequentStringValue;

        public MaterialStringArraySafe SegmentArray;

        public MaterialStringSafe IdentityName;

        public MaterialStringSafe VirtualName;

        public Boolean StickyLeft;

        public Boolean StickyRight;

        public Int32 Layer;

        public Int32 Rank;

        public Int32 LeftPosition;

        public MaterialCharacterSafe LeftCharacter;

        public MaterialCharacterSafe LeftSymmetryCharacter;

        public Boolean LeftSymmetryHas;

        public Int32 RightPosition;

        public MaterialCharacterSafe RightCharacter;

        public MaterialCharacterSafe RightSymmetryCharacter;

        public Boolean RightSymmetryHas;
    }
}
