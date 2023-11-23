using Core;

namespace Core
{
    using System;

    public abstract partial class HHFatal
    {
        public Expression Expression;

        public String[] InformationArray;

        public Exception Exception;

        public HHFatal()
        {
            return;
        }

        ~HHFatal()
        {
            return;
        }

        public HHFatal Initialize(Expression expression, String[] informationArray, Exception exception)
        {
            this.Expression = expression;

            this.InformationArray = informationArray;

            this.Exception = exception;

            return this;

        }
        public static HHFatal Action(HHFatal HHFatal___VALUE)
        {
            var ExceptionStringSafe = ((HHFatal___VALUE.Exception == default) ? String.Empty : HHFatal___VALUE.Exception.ToString());

            Expression.Render($"{HostCode.RenderPath.Core_Host_Fatal}-{HHFatal___VALUE.GetType().Name}", String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(HHFatal) + ' ' + "::" + ' ' + HHFatal___VALUE.GetType().Name + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Expression) + ':' + ' ' + HHFatal___VALUE.Expression,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(InformationArray) + ':' + ' ' + ". . ." + ' ' + $"<{HHFatal___VALUE.InformationArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Expression) + ':',
                String.Empty + HHFatal___VALUE.Expression,
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(InformationArray) + ':',
                String.Empty + String.Join('\n'.ToString(), HHFatal___VALUE.InformationArray),
                String.Empty,
                String.Empty + '~' + "10" + ' ' + ". . . . ." + ':',
                String.Empty + ExceptionStringSafe
            }));

            return HHFatal___VALUE;
        }
    }
}
