using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        private static String ModulationDefaultSwitchDescriptor(String item_NAME, Int32 item_COUNT)
        {
            String stringResult = default;

            var join = String.Empty;

            switch (item_COUNT)
            {
                case 1:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';'
                    });

                    break;

                case 2:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';'
                    });
                    break;

                case 3:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';'
                    });
                    break;

                case 4:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFour(module)" + ';'
                    });
                    break;

                case 5:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFour(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFive(module)" + ';'
                    });
                    break;

                case 6:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFour(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFive(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSix(module)" + ';'
                    });
                    break;

                case 7:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFour(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFive(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSix(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSeven(module)" + ';'
                    });
                    break;

                case 8:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFour(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFive(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSix(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSeven(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionEight(module)" + ';'
                    });
                    break;

                case 9:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFour(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFive(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSix(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSeven(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionEight(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionNine(module)" + ';',
                    });
                    break;

                case 10:
                    join = String.Join('\n'.ToString(), new String[] {

                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionOne(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTwo(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionThree(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFour(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionFive(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSix(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionSeven(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionEight(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionNine(module)" + ';',
                        String.Empty,
                        String.Empty + '\t' + '\t' + '\t' + $"module = {item_NAME}ModuleFunctionTen(module)" + ';'
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
