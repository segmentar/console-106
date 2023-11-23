using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationMetaDescriptor(String item_NAME)
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + "meta" + ' ' + 'O' + ' ' + "META",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + "type" + ' ' + 'O' + ' ' + "TYPE",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + "link" + ' ' + 'O' + ' ' + "LINK",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + "static" + ' ' + 'O' + ' ' + "STATIC",
                String.Empty,
                String.Empty + "sequence" + ' ' + $"{item_NAME}" + ' ' + ':' + ' ' + "no unused namespace(s)",
                String.Empty,
                String.Empty + '\t' + ">" + "Data",
                String.Empty + '\t' + "<<" + $"{item_NAME}Data" + '.' + "cs",
                String.Empty,
                String.Empty + '\t' + ">" + "Prototype",
                String.Empty + '\t' + "<<" + $"{item_NAME}Prototype" + '.' + "cs",
                String.Empty,
                String.Empty + '\t' + "<" + $"{item_NAME}" + '.' + "cs",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"/object\\OBJECT/{item_NAME}Object.cs\\",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"/object\\OBJECT/{item_NAME}DataObject.cs\\",
                String.Empty,
                String.Empty + '\t' + 'o' + ' ' + $"/sequence\\SEQUENCE/{item_NAME}Seqeunce.cs\\",
                String.Empty,
                String.Empty + "end" + ' ' + "sequence"
            });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
