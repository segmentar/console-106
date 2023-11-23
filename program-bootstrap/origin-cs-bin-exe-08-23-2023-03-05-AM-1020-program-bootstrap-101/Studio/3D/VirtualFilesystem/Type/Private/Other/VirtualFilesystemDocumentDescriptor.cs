using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        public static String DocumentDescriptor()
        {
            String stringResult = default;

            var descriptor = new String[] {

                String.Empty,
                String.Empty + '\t' + "This is document" + ' ' + '.',
                String.Empty
            };

            var join = String.Join('\n'.ToString(), descriptor);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
