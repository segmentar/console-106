using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void ProcessLocalLineArray(String Filename_VALUE, String[] LocalLine__ARRAY)
        {
            HostExpression.InstructionHandler(Filename_VALUE, LocalLine__ARRAY);

            Expression.SaveToCurrentDirectory("host", HostExpression);

            Expression expression;

            expression = Expression.LoadFromCurrentDirectory("host");

            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(Host)}SaveStatic", HostExpression);

            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(Host)}LoadStatic", expression.ToString());

            return;
        }
    }
}
