using Core;

namespace Core
{
    using System;

    public partial class ScopeFatal
    {
        public ScopeFatal Initialize(String[] informationArray, Exception exception)
        {
            InformationArray = informationArray;

            Exception = exception;

            return this;
        }
    }
}
