using Core;

namespace Core
{
    using System;

    public partial class ScopearchFatal
    {
        public ScopearchFatal Initialize(String[] informationArray, Exception exception)
        {
            InformationArray = informationArray;

            Exception = exception;

            return this;
        }
    }
}
