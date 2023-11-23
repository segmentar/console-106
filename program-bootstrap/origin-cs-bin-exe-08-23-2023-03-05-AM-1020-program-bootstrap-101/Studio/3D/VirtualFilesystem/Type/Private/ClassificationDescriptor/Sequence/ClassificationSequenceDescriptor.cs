using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationSequenceDescriptor(String item_NAMESPACE, String item_NAME)
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
                String.Empty + '\t' + '\t' + $"internal {item_NAME} Result {{ get; set; }} = default" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + $"internal {item_NAME}Sequence" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "Debug(debug)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{item_NAME} {item_NAME.ToLower()}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{item_NAME.ToLower()} = new {item_NAME}(debug)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"this.Result = {item_NAME.ToLower()}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + '~' + $"{item_NAME}Sequence" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
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
