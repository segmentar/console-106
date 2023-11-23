using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class HostlocallineSequence
    {
        public Hostlocalline Result { get; set; } = default;

        public HostlocallineSequence(String LocalLineInline___VALUE, String[] LocalLineMultiline___ARRAY, Boolean answer_DEBUG_is)
        {
            Debug(LocalLineInline___VALUE, LocalLineMultiline___ARRAY, answer_DEBUG_is);

            var Entity_WHITE_SPACE = Convert.ToChar(32);

            var separator = new Char[] { Entity_WHITE_SPACE };

            var split = LocalLineInline___VALUE.Split(separator, StringSplitOptions.None);

            var first = split[0];

            var second = split[1];

            var aoth = split.Length;

            var roth = (aoth - 2);

            var array = new String[roth];

            Array.Copy(split, 2, array, 0, roth);

            var list = new ArrayList();

            String[] joinArray;

            joinArray = new String[3];

            joinArray[0] = String.Join(Entity_WHITE_SPACE.ToString(), array);

            joinArray[1] = String.Join(Entity_WHITE_SPACE.ToString(), LocalLineMultiline___ARRAY);

            var format = String.Format("{0} {1}", joinArray[0], joinArray[1]);

            foreach (String value in Hostlocalline.ForgeLCWPSplit(format, StringSplitOptions.RemoveEmptyEntries))
            {
                list.Add(value);
            }

            var reflect = (String[])(list.ToArray(typeof(String)) as Array);

            var LocalLineStringValuesafe____VALUE = HostStringSafe.Simple(LocalLineInline___VALUE);

            var LocalLineInstructionStringsafe___VALUE = HostStringSafe.Simple(first);

            var LocalLineStringCallsafe____VALUE = HostStringSafe.Simple(second);

            var LocalLineInlinesafe___ARRAY = HostStringArraySafe.Simple(array);

            var LocalLineMultilinesafe___ARRAY = HostStringArraySafe.Simple(LocalLineMultiline___ARRAY);

            var LocalLineParametersafe___ARRAY = HostStringArraySafe.Simple(reflect);

            Hostlocalline hostlocalline;

            hostlocalline = new Hostlocalline(LocalLineStringValuesafe____VALUE, LocalLineInstructionStringsafe___VALUE, LocalLineStringCallsafe____VALUE, LocalLineInlinesafe___ARRAY, LocalLineMultilinesafe___ARRAY, LocalLineParametersafe___ARRAY, answer_DEBUG_is);

            this.Result = hostlocalline;

            return;
        }

        ~HostlocallineSequence()
        {
            return;
        }
    }
}
