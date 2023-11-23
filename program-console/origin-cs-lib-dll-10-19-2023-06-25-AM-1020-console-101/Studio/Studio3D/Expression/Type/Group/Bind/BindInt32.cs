using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void BindInt32(Object item_OBJECT)
        {
            String stringItem;

            stringItem = item_OBJECT.ToString();

            var parse = Int32.Parse(stringItem);

            Bind(parse);

            return;
        }
    }
}
