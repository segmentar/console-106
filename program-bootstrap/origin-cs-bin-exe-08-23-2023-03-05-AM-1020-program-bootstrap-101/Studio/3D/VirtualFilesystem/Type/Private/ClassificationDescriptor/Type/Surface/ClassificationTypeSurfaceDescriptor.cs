using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        public static String ClassificationTypeSurfaceDescriptor(String item_NAMESPACE, String item_NAME)
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
                String.Empty + '\t' + '\t' + $"internal static {item_NAME} Make{item_NAME}DefaultSurface" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{item_NAME} {item_NAME.ToLower()}Result = default" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{item_NAME.ToLower()}Result = Make{item_NAME}Default({item_NAME}Policy.{item_NAME}DebugPolicy)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"return {item_NAME.ToLower()}Result" + ';',
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
