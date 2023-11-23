using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationLinkPolicyDescriptor(String item_NAMESPACE, String item_NAME)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + item_NAMESPACE + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + item_NAMESPACE,
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + "using" + ' ' + "System" + '.' + "Collections" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {item_NAME}Policy",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal static ArrayList {item_NAME}ArrayList = new ArrayList()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + $"internal static Boolean {item_NAME}DebugPolicy = false" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + $"internal static Boolean {item_NAME}InfoPolicy = false" + ';',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
