using Core;

namespace Core
{
    using System;

    public partial class Virtualfile
    {
        public Virtualfile(String filename, Byte[] contentByteArray, Boolean debug)
        {
            this.Filename = filename;

            this.ContentByteArray = contentByteArray;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
