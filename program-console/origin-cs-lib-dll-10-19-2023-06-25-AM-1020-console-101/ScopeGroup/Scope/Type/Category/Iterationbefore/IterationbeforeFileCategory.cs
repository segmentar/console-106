using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void IterationbeforeFileCategory()
        {
            ValidatePrimary();

            ValidateSecondary();

            ValidateTertiary();

            ValidateQuaternary();

            ValidateQuinary();

            FilePrimaryIteration();

            return;
        }
    }
}
