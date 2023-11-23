using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFlag
    {
        public Boolean EndOfFileArrayFlag;

        public Boolean EndOfFileFlag;

        public Boolean LocalLineFlag;

        public Boolean GlobalLineFlag;

        public Boolean MaterialHeaderFlag;

        public Boolean MaterialFooterFlag;

        public Boolean MaterialValidateFlag;

        public Boolean ScopeShutdownFlag;
    }
}