using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ModulationNumberthDescriptor(String item_NAME, String item_NAMESPACE, String item_NUMBERTH)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + item_NAMESPACE + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + item_NAMESPACE,
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {item_NAME}ModuleFunction{item_NUMBERTH}",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunction{item_NUMBERTH}" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + '~' + $"{item_NAME}ModuleFunction{item_NUMBERTH}" + '(' + ')',
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
