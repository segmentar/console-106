using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ModulationNumberDescriptor(String item_NAME, String item_NAMESPACE, String item_NUMBERTH, String item_NUMBER)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + item_NAMESPACE + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + item_NAMESPACE,
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {item_NAME}Module",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal static {item_NAME}Module {item_NAME}ModuleFunction{item_NUMBER}" + '(' + $"{item_NAME}Module module" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{item_NAME}ModuleFunction{item_NUMBERTH} {item_NUMBERTH}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{item_NUMBERTH} = new {item_NAME}ModuleFunction{item_NUMBERTH}()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"module.{item_NUMBERTH} = {item_NUMBERTH}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return module" + ';',
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
