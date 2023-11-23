using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFilesystem
    {
        public static VirtualFolder AddClass(VirtualFolder item__VIRTUAL_FOLDER, String item_NAME, String item_NAMESPACE, Boolean answer_STATIC_is)
        {
            VirtualFolder virtualFolderResult = default; 

            var program = AddFolder(item__VIRTUAL_FOLDER, item_NAME);
            
            var program_DATA = AddFolder(program, "Data");

            var program_LINK = AddFolder(program,"Link");

            var program_LINK__POLICY = AddFolder(program_LINK, "Policy");

            var program_META = AddFolder(program, "Meta");

            var program_MODULE = AddFolder(program, "Module");

            var program_OBJECT = AddFolder(program, "Object");

            var program_OBJECT__PROGRAM_OBJECT = AddFolder(program_OBJECT, $"{item_NAME}Object");

            var program_OBJECT__PROGRAM_DATA_OBJECT = AddFolder(program_OBJECT, $"{item_NAME}DataObject");

            var program_PROTOTYPE = AddFolder(program, "Prototype");

            if (answer_STATIC_is is true)
            {
                var program_STATIC = AddFolder(program, "Static");

                var program__PROGRAM__STATIC = AddFile(program_STATIC, $"{item_NAME}Static", "cs", ClassificationStaticDescriptor(item_NAMESPACE, item_NAME));
            }
            else
                "false".ToString();

            var program_TYPE = AddFolder(program, "Type");

            var program_TYPE__MAKE = AddFolder(program_TYPE, "Make");

            var program_TYPE__MAKE__DEFAULT = AddFolder(program_TYPE__MAKE, "Default");

            var program_TYPE__MAKE__DEFAULT__SURFACE = AddFolder(program_TYPE__MAKE__DEFAULT, "Surface");

            var program_TYPE__SEQUENCE = AddFolder(program, "Sequence");

            var program_TYPE__SEQUENCE__DEBUG = AddFolder(program_TYPE__SEQUENCE, "Debug");

            var program__PROGRAM__DATA = AddFile(program_DATA, $"{item_NAME}Data", "cs", ClassificationDataDescriptor(item_NAMESPACE, item_NAME));

            var program__PROGRAM__LINK__POLICY = AddFile(program_LINK__POLICY, $"{item_NAME}LinkPolicy", "cs", ClassificationLinkPolicyDescriptor(item_NAMESPACE, item_NAME));

            var program__PROGRAM__META = AddFile(program_META, $"{item_NAME}Meta", "txt", ClassificationMetaDescriptor(item_NAME));

            var program__PROGRAM__OBJECT__PROGRAM_OBJECT = AddFile(program_OBJECT__PROGRAM_OBJECT, $"{item_NAME}Object", "cs", ClassificationObjectDescriptor(item_NAMESPACE, item_NAME));

            var program__PROGRAM__OBJECT__PROGRAM_DATA_OBJECT = AddFile(program_OBJECT__PROGRAM_DATA_OBJECT, $"{item_NAME}DataObject", "cs", ClassificationDataObjectDescriptor(item_NAMESPACE, item_NAME));
            
            var program__PROGRAM__PROTOTYPE = AddFile(program_PROTOTYPE, $"{item_NAME}Prototype", "cs", ClassificationPrototypeDescriptor(item_NAMESPACE, item_NAME));
            
            var program__PROGRAM__TYPE__MAKE__DEFAULT = AddFile(program_TYPE__MAKE__DEFAULT, $"{item_NAME}MakeDefault", "cs", ClassificationTypeDescriptor(item_NAMESPACE, item_NAME));

            var program__PROGRAM__TYPE__MAKE__DEFAULT__SURFACE = AddFile(program_TYPE__MAKE__DEFAULT__SURFACE, $"{item_NAME}MakeDefaultSurface", "cs", ClassificationTypeSurfaceDescriptor(item_NAMESPACE, item_NAME));
            
            var program__PROGRAM__TYPE__SEQUENCE = AddFile(program_TYPE__SEQUENCE, $"{item_NAME}Sequence", "cs", ClassificationSequenceDescriptor(item_NAMESPACE, item_NAME));

            var program__PROGRAM__TYPE__SEQUENCE__DEBUG = AddFile(program_TYPE__SEQUENCE__DEBUG, $"{item_NAME}SequenceDebug", "cs", ClassificationSequenceDebugDescriptor(item_NAMESPACE, item_NAME));
            
            var program__PROGRAM__STANDALONE = AddFile(program, $"{item_NAME}", "cs", ClassificationStandaloneDescriptor(item_NAMESPACE, item_NAME));
            
            virtualFolderResult = program;

            return virtualFolderResult;
        }
    }
}
