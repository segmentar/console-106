﻿using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ClassificationObjectDescriptor(String item_NAMESPACE, String item_NAME)
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
                String.Empty + '\t' + '\t' + "public override String ToString" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return Data.ToString()" + ';',
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
