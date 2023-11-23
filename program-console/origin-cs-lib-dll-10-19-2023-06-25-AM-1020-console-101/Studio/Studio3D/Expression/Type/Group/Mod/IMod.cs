using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expression
    {
        public LinkedList<Expression> IMod()
        {
            LinkedList<Expression> listResult = default;

            var array = ViewList.ToArray(typeof(Expression));

            var reflect = (Expression[])(array as Array);

            var list = new LinkedList<Expression>(reflect);

            listResult = list;

            return listResult;
        }
    }
}
