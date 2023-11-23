using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ModulationEntrySwitchDescriptor(String item_NAME, Int32 item_COUNT)
        {
            String stringResult = default;

            var join = String.Empty;

            switch (item_COUNT)
            {
                case 1:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';'
                    });
                    break;

                case 2:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                    });
                    break;

                case 3:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';'
                    });
                    break;

                case 4:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFourth Fourth" + ';'
                    });
                    break;

                case 5:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFourth Fourth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFifth Fifth" + ';'
                    });
                    break;

                case 6:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFourth Fourth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFifth Fifth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSixth Sixth" + ';'
                    });
                    break;

                case 7:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFourth Fourth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFifth Fifth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSixth Sixth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSeventh Seventh" + ';'
                    });
                    break;

                case 8:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFourth Fourth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFifth Fifth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSixth Sixth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSeventh Seventh" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionEighth Eighth" + ';'
                    });
                    break;

                case 9:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFourth Fourth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFifth Fifth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSixth Sixth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSeventh Seventh" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionEighth Eighth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionNinth Ninth" + ';'
                    });
                    break;

                case 10:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFirst First" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSecond Second" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionThird Third" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFourth Fourth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionFifth Fifth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSixth Sixth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionSeventh Seventh" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionEighth Eighth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionNinth Ninth" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + $"internal {item_NAME}ModuleFunctionTen Tenth" + ';'
                    });
                    break;

                default:
                    break;
            }

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
