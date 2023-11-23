using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        public static String ReadMeDescriptor()
        {
            String stringResult = default;

            var descriptor = new String[] {

                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + "Keep your .AppConfig file, and move it to the Studio/4D folder" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + 'O' + ' ' + "Make yourself a personalized 512/512 pixel .ico" + ' ' + '.',
                String.Empty
            };

            var join = String.Join('\n'.ToString(), descriptor);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
