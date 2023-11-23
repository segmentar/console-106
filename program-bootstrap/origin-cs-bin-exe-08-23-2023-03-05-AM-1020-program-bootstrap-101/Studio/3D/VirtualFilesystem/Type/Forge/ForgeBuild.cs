using Core;

using Core.DimensionTwoSecond;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        internal static String Build(String item__WORKING_DIRECTORY)
        {
            String stringResult = default;

            VirtualFolder virtualFolder;
            
            virtualFolder = new VirtualFolderSimple(item__WORKING_DIRECTORY).Result;

            VirtualFilesystem virtualFilesystem;

            virtualFilesystem = new VirtualFilesystemSimple(virtualFolder).Result;

            String applicationString;

            switch (ArchitectureTwoSecond.ApplicationType)
            {
                case ProgramCode.ApplicationType.BinaryPortableExecutable:
                    applicationString = "bin-exe";
                    break;

                case ProgramCode.ApplicationType.LibraryDynamicLinkLibrary:
                    applicationString = "lib-dll";
                    break;

                default:
                    applicationString = String.Empty;
                    break;
            }

            var origin = AddFolder(virtualFilesystem.VirtualFolderRoot, ForgeOriginName(ArchitectureTwoSecond.ApplicationName, applicationString, ArchitectureTwoSecond.ApplicationVersion));

            var origin__READ_ME = AddFile(origin, "ReadMe", "txt", ReadMeDescriptor());

            var dash = Convert.ToChar(45);

            var separator = new String[] { dash.ToString() };

            var split_CLASS = ArchitectureTwoSecond.ClassStringBuilder.ToString().Split(separator, StringSplitOptions.None);
            
            var split_MODULE = ArchitectureTwoSecond.ModuleStringBuilger.ToString().Split(separator, StringSplitOptions.None);

            var split_ICON = ArchitectureTwoSecond.IconStringBuilder.ToString().Split(separator, StringSplitOptions.None);

            foreach (Tuple<String, String, String, String> tuple in Program.ProgramClassificationContainerSurface<Tuple<String, String, String, String>>(split_CLASS))
            {
                String classificationCall, classificationName, classificationNamespace, classificationStatic;

                classificationCall = tuple.Item1;

                classificationName = tuple.Item2;

                classificationNamespace = tuple.Item3;

                classificationStatic = tuple.Item4;

                Boolean classificationStaticBooleanCheck;

                classificationStaticBooleanCheck = Boolean.Parse(classificationStatic);

                AddClass(origin, classificationName, classificationNamespace, classificationStaticBooleanCheck);

                continue;
            }
            /*

            foreach (var tuple in ProgramModuleTupleSetSurface(split_MODULE))
            {
                Int32 integerResult;

                Boolean booleanResult;

                booleanResult = Int32.TryParse(tuple.Item3, out integerResult);

                if (booleanResult is false)
                {
                    continue;
                }
                else
                    "false".ToString();

                origin.AddModule(tuple.Item2, integerResult); 
               
                continue;
            }

            if (ArchitectureTwoSecond.StudioType is ProgramCode.StudioType.IncludeStudioDirectory)
            {
                var studio = origin.AddFolder("Studio");

                var studio_1D = studio.AddFolder("1D");

                var studio_2D = studio.AddFolder("2D");

                var studio_3D = studio.AddFolder("3D");

                var studio_4D = studio.AddFolder("4D");

                var studio__1D__DOCUMENT = studio_1D.AddFile("Document", "txt", descriptor__DOCUMENT);
            }
            else
                "false".ToString();
            */
            virtualFilesystem.Render();
            /*
            var ordinal = 1;

            foreach (var tuple in ProgramIconTupleSetSurface(split_ICON))
            {
                Color foregroundColor, backgroundColor;
                
                foregroundColor = Color.FromName(tuple.Item3);

                backgroundColor = Color.FromName(tuple.Item4);

                Single impact;

                impact = Single.Parse(tuple.Item5);

                Int32 scale;

                scale = Int32.Parse(tuple.Item6);

                var path_NAME = $"{tuple.Item2}-{ordinal}";

                var path_DIRECTORY_full_name = origin.FullName;

                var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, path_NAME);

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, "png");

                MakeIcon(path_FILE_filename_with_extension, foregroundColor, backgroundColor, impact, scale);

                ordinal = ordinal + 1;

                continue;
            }*/

            var result = item__WORKING_DIRECTORY;

            stringResult = result;

            return stringResult;
        }
    }
}
