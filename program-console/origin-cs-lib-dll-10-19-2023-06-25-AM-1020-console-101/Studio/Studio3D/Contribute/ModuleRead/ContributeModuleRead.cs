using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleRead
    {
        public ContributeModuleReadCycle.FunctionRead FunctionRead;

        public ContributeModuleReadCycle.FunctionHeader FunctionHeader;

        public ContributeModuleReadCycle.FunctionA[] FunctionArrayA;

        public ContributeModuleReadCycle.FunctionAA FunctionAA;

        public ContributeModuleReadInline.FunctionFirst First;        
    }
}
