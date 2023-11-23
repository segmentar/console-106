using Core;

namespace Core
{
    using System;

    public partial class Hostlocalline
    {
        public Hostlocalline(HostStringSafe stringValue, HostStringSafe stringInstruction, HostStringSafe stringCall, HostStringArraySafe inlineArray, HostStringArraySafe multilineArray, HostStringArraySafe parameterArray, Boolean answer_DEBUG_is)
        {
            this.StringValue = stringValue;

            this.StringInstruction = stringInstruction;

            this.StringCall = stringCall;

            this.InlineArray = inlineArray;

            this.MultilineArray = multilineArray;

            this.ParameterArray = parameterArray;

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
