using Core;

using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFolder
    {
        public VirtualFolder AddClass(String name)
        {
            VirtualFolder virtualFolderResult = default;

            var descriptor__PROGRAM__STATIC = String.Join('\n'.ToString(), new String[] {
            
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + "internal partial class Program",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal static String[] ArgumentArray" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Main" + '(' + "params String[] array_ARGUMENT" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "ArgumentArray = array_ARGUMENT" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "Bundle()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Procedure" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Manual" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Raise" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "internal static void Bundle" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "Procedure()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "Manual()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "Raise()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + "static Program" + '(' + ')' + ' ' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var descriptor__PROGRAM__TYPE__MAKE__DEFAULT = String.Join('\n'.ToString(), new String[] {
            
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal static {name} Make{name}Default" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{name} {name.ToLower()}Result = default" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"var result = new {name}Sequence(debug).Result" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{name.ToLower()}Result = result" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"return {name.ToLower()}Result" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var descriptor__PROGRAM__TYPE__MAKE__DEFAULT__SURFACE = String.Join('\n'.ToString(), new String[] {
            
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal static {name} Make{name}DefaultSurface" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + $"{name} {name.ToLower()}Result = default" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{name.ToLower()}Result = Make{name}Default(Policy.{name}DebugPolicy)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"return {name.ToLower()}Result" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var descriptor__PROGRAM__TYPE__SEQUENCE = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}Sequence",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + $"internal {name} Result {{ get; set; }} = default" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + $"internal {name}Sequence" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "Debug(debug)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{name} {name.ToLower()}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"{name.ToLower()} = new {name}(debug)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + $"this.Result = {name.ToLower()}" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty,
                String.Empty + '\t' + '\t' + '~' + $"{name}Sequence" + '(' + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';',
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var descriptor__PROGRAM__TYPE__SEQUENCE__DEBUG = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + "using" + ' ' + "Core" + ';',
                String.Empty,
                String.Empty + "namespace" + ' ' + "Core",
                String.Empty + '{',
                String.Empty + '\t' + "using" + ' ' + "System" + ';',
                String.Empty,
                String.Empty + '\t' + $"internal partial class {name}Sequence",
                String.Empty + '\t' + '{',
                String.Empty + '\t' + '\t' + "internal static void Debug" + '(' + "Boolean debug" + ')',
                String.Empty + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + "if (debug is true)",
                String.Empty + '\t' + '\t' + '\t' + '{',
                String.Empty + '\t' + '\t' + '\t' + '\t' + "var descriptor = String.Join('\\n'.ToString(), new String[] {",
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + $"String.Empty + nameof({name}) + ' ' + \"::\" + ' ' + nameof({name}Sequence) + ' ' + '{{'" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '.' + \"debug\"" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '\\t' + '~' + \"01\" + ' ' + nameof(debug) + ':' + ' ' + debug" + ',',
                String.Empty + '\t' + '\t' + '\t' + '\t' + '\t' + "String.Empty + '}'",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "})" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.Clear()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.Out.WriteLine(descriptor)" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + '\t' + "Console.In.ReadLine()" + ';',
                String.Empty + '\t' + '\t' + '\t' + '}',
                String.Empty + '\t' + '\t' + '\t' + "else",
                String.Empty + '\t' + '\t' + '\t' + '\t' + "\"false\".ToString()" + ';',
                String.Empty,
                String.Empty + '\t' + '\t' + '\t' + "return" + ';', 
                String.Empty + '\t' + '\t' + '}',
                String.Empty + '\t' + '}',
                String.Empty + '}'
            });

            var program = AddFolder(name);

            var program_DATA = program.AddFolder("Data");

            var program_LINK = program.AddFolder("Link");

            var program_LINK__POLICY = program_LINK.AddFolder("Policy");

            var program_META = program.AddFolder("Meta");

            var program_MODULE = program.AddFolder("Module");

            var program_OBJECT = program.AddFolder("Object");

            var program_OBJECT__PROGRAM_OBJECT = program_OBJECT.AddFolder($"{name}Object");

            var program_OBJECT__PROGRAM_DATA_OBJECT = program_OBJECT.AddFolder($"{name}DataObject");

            var program_PROTOTYPE = program.AddFolder("Prototype");

            var program_STATIC = program.AddFolder("Static");

            var program_TYPE = program.AddFolder("Type");

            var program_TYPE__MAKE = program_TYPE.AddFolder("Make");

            var program_TYPE__MAKE__DEFAULT = program_TYPE__MAKE.AddFolder("Default");

            var program_TYPE__MAKE__DEFAULT__SURFACE = program_TYPE__MAKE__DEFAULT.AddFolder("Surface");

            var program_TYPE__SEQUENCE = program_TYPE.AddFolder("Sequence");

            var program_TYPE__SEQUENCE__DEBUG = program_TYPE__SEQUENCE.AddFolder("Debug");

            var program__PROGRAM__DATA = program_DATA.AddFile($"{name}Data", "cs", ClassificationDataDescriptor(name));

            var program__PROGRAM__LINK__POLICY = program_LINK__POLICY.AddFile($"{name}LinkPolicy", "cs", ClassificationLinkPolicyDescriptor(name));

            var program__PROGRAM__META = program_META.AddFile($"{name}Meta", "txt", ClassificationMetaDescriptor(name));

            var program__PROGRAM__OBJECT__PROGRAM_OBJECT = program_OBJECT__PROGRAM_OBJECT.AddFile($"{name}Object", "cs", ClassificationObjectDescriptor(name));

            var program__PROGRAM__OBJECT__PROGRAM_DATA_OBJECT = program_OBJECT__PROGRAM_DATA_OBJECT.AddFile($"{name}DataObject", "cs", ClassificationDataObjectDescriptor(name));

            var program__PROGRAM__PROTOTYPE = program_PROTOTYPE.AddFile($"{name}Prototype", "cs", ClassificationPrototypeDescriptor(name));

            var program__PROGRAM__STATIC = program_STATIC.AddFile($"{name}Static", "cs", descriptor__PROGRAM__STATIC);

            var program__PROGRAM__TYPE__MAKE__DEFAULT = program_TYPE__MAKE__DEFAULT.AddFile($"{name}MakeDefault", "cs", descriptor__PROGRAM__TYPE__MAKE__DEFAULT);

            var program__PROGRAM__TYPE__MAKE__DEFAULT__SURFACE = program_TYPE__MAKE__DEFAULT__SURFACE.AddFile($"{name}MakeDefaultSurface", "cs", descriptor__PROGRAM__TYPE__MAKE__DEFAULT__SURFACE);

            var program__PROGRAM__TYPE__SEQUENCE = program_TYPE__SEQUENCE.AddFile($"{name}Sequence", "cs", descriptor__PROGRAM__TYPE__SEQUENCE);

            var program__PROGRAM__TYPE__SEQUENCE__DEBUG = program_TYPE__SEQUENCE__DEBUG.AddFile($"{name}SequenceDebug", "cs", descriptor__PROGRAM__TYPE__SEQUENCE__DEBUG);

            var program__PROGRAM__ENTRY = program.AddFile($"{name}", "cs", ClassificationEntryDescriptor(name));
            
            virtualFolderResult = program;

            return virtualFolderResult;
        }
    }
}
