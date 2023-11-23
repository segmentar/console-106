using Core;

namespace Core
{
    using System;

    public partial class FunctionPrimary
    {
        public Tuple<String, Tuple<Char, String[]>[]> Tuple;

        public FunctionPrimary(Tuple<String, Tuple<Char, String[]>[]> tuple)
        {
            this.Tuple = tuple;

            return;
        }

        ~FunctionPrimary()
        {
            return;
        }
    }
}
