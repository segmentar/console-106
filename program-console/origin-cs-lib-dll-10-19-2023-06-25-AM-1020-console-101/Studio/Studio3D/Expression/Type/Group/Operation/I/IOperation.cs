using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void IOperation(String Filename_VALUE, Stack value_STACK, String[] Parameter_ARRAY, String[] Split_ARRAY, String[] SplitTruncate__ARRAY, String Lower_VALUE)
        {
            switch (Lower_VALUE)
            {
                /*case ExpressionConstant.OperationCSharpInt32Addition:
                    CSharpHostInt32Addition(this, array);
                    break;

                case HostConstant.SystemHostCreateFolder:
                    Host.SystemHostCreateFolder(this, array);
                    break;

                case HostConstant.SystemHostCreateFile:
                    Host.SystemHostCreateFile(this, array);
                    break;

                case HostConstant.SystemHostAppendText:
                    Host.SystemHostAppendText(this, array);
                    break;*/

                case HostConstant.SystemHostCurrentDirectory:
                    Host.SystemHostCurrentDirectory(this, Parameter_ARRAY);
                    break;

                case HostConstant.SystemHostPathCombine:
                    Host.SystemHostPathCombine(this, Parameter_ARRAY);
                    break;

                case HostConstant.SystemHostCreateFolder:
                    Host.SystemHostCreateFolder(this, Parameter_ARRAY);
                    break;

                case HostConstant.SystemHostCreateFile:
                    Host.SystemHostCreateFile(this, Parameter_ARRAY);
                    break;

                case HostConstant.SystemHostChangeExtension:
                    Host.SystemHostChangeExtension(this, Parameter_ARRAY);
                    break;

                case HostConstant.SystemHostOpenWrite:
                    Host.SystemHostOpenWrite(this, Parameter_ARRAY);
                    break;

                case HostConstant.SystemHostClose:
                    Host.SystemHostClose(this, Parameter_ARRAY);
                    break;

                default:
                    break;
            }
            return;
        }
    }
}
