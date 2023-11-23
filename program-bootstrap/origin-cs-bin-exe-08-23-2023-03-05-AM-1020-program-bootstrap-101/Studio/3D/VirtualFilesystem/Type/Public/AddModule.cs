using Core;

using Core.DimensionTwoSecond;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFolder
    {
        public VirtualFolder AddModule(String item_NAME, String item_NAMESPACE, Int32 item_COUNT)
        {
            VirtualFolder virtualFolderResult = default;

            var descriptor__MODULE__ENTRY__descriptor = ModulationEntrySwitchDescriptor(item_NAME, item_NAMESPACE, item_COUNT);

            var descriptor__MODULE__DEFAULT_descriptor = ModulationDefaultSwitchDescriptor(item_NAME, item_NAMESPACE, item_COUNT);

            var descriptor__MODULE__ENTRY = String.Join('\n'.ToString(), new String[] {

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {item_NAME}Module",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal Object Object" + ';',
                String.Empty,
                String.Empty + descriptor__MODULE__ENTRY__descriptor,
                String.Empty,
                String.Empty + '\t' + '}',
                String.Empty + '}',
            });

            var descriptor__MODULE__DEFAULT = String.Join('\n'.ToString(), new String[] { 

                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial struct {item_NAME}Module",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal static {item_NAME}Module {item_NAME}ModuleDefault" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{item_NAME}Module module" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"module = new {item_NAME}Module()" + ';',
                String.Empty,
                String.Empty + descriptor__MODULE__DEFAULT_descriptor,
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return module" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            
            });

            var module = AddFolder($"{item_NAME}Module");

            var module_DEFAULT = module.AddFolder("Default");   

            var module_FUNCTION = module.AddFolder("Function");

            switch (item_COUNT)
            {
                case 1:
                    module_FUNCTION.AddFolder("01");
                    break;

                case 2:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    break;

                case 3:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    break;

                case 4:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    break;

                case 5:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    module_FUNCTION.AddFolder("05");
                    break;

                case 6:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    module_FUNCTION.AddFolder("05");
                    module_FUNCTION.AddFolder("06");
                    break;

                case 7:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    module_FUNCTION.AddFolder("05");
                    module_FUNCTION.AddFolder("06");
                    module_FUNCTION.AddFolder("07");
                    break;

                case 8:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    module_FUNCTION.AddFolder("05");
                    module_FUNCTION.AddFolder("06");
                    module_FUNCTION.AddFolder("07");
                    module_FUNCTION.AddFolder("08");
                    break;

                case 9:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    module_FUNCTION.AddFolder("05");
                    module_FUNCTION.AddFolder("06");
                    module_FUNCTION.AddFolder("07");
                    module_FUNCTION.AddFolder("08");
                    module_FUNCTION.AddFolder("09");
                    break;

                case 10:
                    module_FUNCTION.AddFolder("01");
                    module_FUNCTION.AddFolder("02");
                    module_FUNCTION.AddFolder("03");
                    module_FUNCTION.AddFolder("04");
                    module_FUNCTION.AddFolder("05");
                    module_FUNCTION.AddFolder("06");
                    module_FUNCTION.AddFolder("07");
                    module_FUNCTION.AddFolder("08");
                    module_FUNCTION.AddFolder("09");
                    module_FUNCTION.AddFolder("10");
                    break;

                default:
                    break;
            }

            var ordinal = 1;

            foreach (VirtualFolder virtualFolder in VirtualFolderFolderSetSurface(module_FUNCTION))
            {
                String number, numberth;

                number = default;

                numberth = default;

                switch (ordinal)
                {
                    case 1:
                        number = "One";
                        numberth = "First";
                        break;

                    case 2:
                        number = "Two";
                        numberth = "Second";
                        break;

                    case 3:
                        number = "Three";
                        numberth = "Third";
                        break;

                    case 4:
                        number = "Four";
                        numberth = "Fourth";
                        break;

                    case 5:
                        number = "Five";
                        numberth = "Fifth";
                        break;

                    case 6:
                        number = "Six";
                        numberth = "Sixth";
                        break;

                    case 7:
                        number = "Seven";
                        numberth = "Seventh";
                        break;

                    case 8:
                        number = "Eight";
                        numberth = "Eighth";
                        break;

                    case 9:
                        number = "Nine";
                        numberth = "Ninth";
                        break;

                    case 10:
                        number = "Ten";
                        numberth = "Tenth";
                        break;

                    default:
                        break;
                }

                var descriptor_NUMBER = ModulationNumberDescriptor(item_NAME, numberth, number);

                var descriptor_NUMBERTH = ModulationNumberthDescriptor(item_NAME, numberth);

                var folder_NUMBER = virtualFolder.AddFolder(number);

                var folder_NUMBERTH = virtualFolder.AddFolder(numberth);

                var file_NUMBER = folder_NUMBER.AddFile($"{item_NAME}ModuleFunction{number}", "cs", descriptor_NUMBER);

                var file_NUMBERTH = folder_NUMBERTH.AddFile($"{item_NAME}ModuleFunction{numberth}", "cs", descriptor_NUMBERTH);

                ordinal = ordinal + 1;

                continue;
            }

            var module__MODULE__ENTRY = module.AddFile($"{item_NAME}Module", "cs", descriptor__MODULE__ENTRY);

            var module__MODULE__DEFAULT = module_DEFAULT.AddFile($"{item_NAME}ModuleDefault", "cs", descriptor__MODULE__DEFAULT);

            virtualFolderResult = module;

            return virtualFolderResult;
        }
    }
}