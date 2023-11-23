using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationSequenceDebugDescriptor(String item_NAMESPACE, String item_NAME)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + item_NAMESPACE + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + item_NAMESPACE,
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {item_NAME}Sequence",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal static void Debug" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "if (debug is true)",
                String.Empty + '\t' + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "var descriptor = String.Join('\\n'.ToString(), new String[] {",
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + $"String.Empty + nameof({item_NAME}) + ' ' + \"::\" + ' ' + nameof({item_NAME}Sequence) + ' ' + '{{'" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '.' + \"debug\"" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '\\t' + '~' + \"01\" + ' ' + nameof(debug) + ':' + ' ' + debug" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '}'",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "})" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.Clear()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.Out.WriteLine(descriptor)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.In.ReadLine()" + ';',
                String.Empty + '\t' + '\t' + '\t' + '}',
                String.Empty + '\t' + '\t' + '\t' + "else",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "\"false\".ToString()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
