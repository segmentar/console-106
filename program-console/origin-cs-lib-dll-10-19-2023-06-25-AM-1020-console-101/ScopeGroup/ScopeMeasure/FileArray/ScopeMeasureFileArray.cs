using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFileArray
    {
        public String[] FileArray;

        public Int32 FilePointer;

        public ScopeStringSafe Filename;

        public ScopeStringSafe Text;
    }
}