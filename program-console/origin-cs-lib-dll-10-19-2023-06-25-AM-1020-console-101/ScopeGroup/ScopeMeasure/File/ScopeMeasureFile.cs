using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFile
    {
        public Int32 PhysicalOffset;

        public Int32 RelateOffset;

        public Int32 VirtualOffset;

        public Int32 LineNumber;

        public ScopeCharacterSafe Character;

        public ScopeCharacterSafe CharacterProof;

        public ScopeStringSafe Line;
    }
}