using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationPrototypeDescriptor(String item_NAMESPACE, String item_NAME)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + item_NAMESPACE + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + item_NAMESPACE,
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {item_NAME}",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal {item_NAME}" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{item_NAME}Data data" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"data = new {item_NAME}Data" + '(' + ')' + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "if (debug is true)",
                String.Empty + '\t' + '\t' + '\t' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "data.IsDebug = true" + ';',
                String.Empty + '\t' + '\t' + '\t' + '}',
                String.Empty + '\t' + '\t' + '\t' + "else",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "\"false\".ToString()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "this.Data = data" + ';',
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
