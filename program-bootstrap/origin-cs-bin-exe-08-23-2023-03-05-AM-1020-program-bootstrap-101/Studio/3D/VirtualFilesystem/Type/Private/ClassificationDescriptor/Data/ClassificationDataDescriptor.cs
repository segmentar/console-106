using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationDataDescriptor(String item_NAMEPSACE, String item_NAME)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + item_NAMEPSACE + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + item_NAMEPSACE,
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {item_NAME}Data",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal Boolean IsDebug" + ';',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
