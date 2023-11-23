using Core;

namespace Core
{
    using System;

    public abstract partial class HFatal
    {
        public String Filename;

        public String[] InformationArray;

        public Exception Exception;

        public HFatal()
        {
            return;
        }

        ~HFatal()
        {
            return;
        }

        public HFatal Initialize(String filename, String[] informationArray, Exception exception)
        {
            this.Filename = filename;

            this.InformationArray = informationArray;

            this.Exception = exception;

            return this;

        }
        public static HFatal Action(HFatal HFatal__VALUE)
        {
            var ExceptionStringSafe = ((HFatal__VALUE.Exception == default) ? String.Empty : HFatal__VALUE.Exception.ToString());

            Expression.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}-{HFatal__VALUE.GetType().Name}", String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(HFatal) + ' ' + "::" + ' ' + HFatal__VALUE.GetType().Name + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Filename) + ':' + ' ' + HFatal__VALUE.Filename,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(InformationArray) + ':' + ' ' + ". . ." + ' ' + $"<{HFatal__VALUE.InformationArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(InformationArray) + ':',
                String.Empty + String.Join('\n'.ToString(), HFatal__VALUE.InformationArray),
                String.Empty,
                String.Empty + '~' + "10" + ' ' + ". . . . ." + ':',
                String.Empty + ExceptionStringSafe
            }));

            return HFatal__VALUE;
        }
    }
}
