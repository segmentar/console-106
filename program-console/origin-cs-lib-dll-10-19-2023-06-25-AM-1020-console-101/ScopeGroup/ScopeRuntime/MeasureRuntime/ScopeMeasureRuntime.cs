using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void MeasureRuntime()
        {
            MeasureWaitRuntime();

            MeasureFileArrayRuntime();

            MeasureFileRuntime();

            MeasureFlagRuntime();

            MeasureQueryRuntime();

            MeasureValidateRuntime();

            MeasureInstructionRuntime();

            MeasureFolderRuntime();

            MeasureValueRuntime();

            return;
        }
    }
}
