using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationDataObjectDescriptor(String item_NAMESPACE, String item_NAME)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + item_NAMESPACE + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + item_NAMESPACE,
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {item_NAME}Data",
                String.Empty + '\t' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + "public override String ToString" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return String.Join('\\n'.ToString(), new String[] {",
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + $"String.Empty + nameof({item_NAME}) + ' ' + \"::\" + ' ' + nameof({item_NAME}Data) + ' ' + '{{'" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "String.Empty + '.' + \"data\"" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "String.Empty + '\\t' + '~' + \"01\" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "String.Empty + '}'",
                String.Empty + '\t' + '\t' + '\t' + "})" + ';',
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
