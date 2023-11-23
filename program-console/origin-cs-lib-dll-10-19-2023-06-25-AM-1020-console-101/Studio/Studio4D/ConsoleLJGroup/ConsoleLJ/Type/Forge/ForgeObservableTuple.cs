using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public static Tuple<String[], String[]> ForgeObservableTuple__FILE_DIRECTORY(String item_DIRECTORY, Boolean answer_OVERRIDE_should)
        {
            Tuple<String[], String[]> tupleResult = default;

            Tuple<String[], String[]> tuple;

            String[] fileArray, directoryArray;

            directoryArray = ConsoleLJFolderSetSurface(item_DIRECTORY);

            var boolean_match_OVERRIDE_should = true;

            boolean_match_OVERRIDE_should = boolean_match_OVERRIDE_should && answer_OVERRIDE_should is true;

            boolean_match_OVERRIDE_should = boolean_match_OVERRIDE_should && ArchitectureConsoleLJOneFirst.HasInputDirectory is true;

            Boolean shouldOverrideCheck;

            shouldOverrideCheck = boolean_match_OVERRIDE_should is true;

            if (shouldOverrideCheck is true)
            {
                directoryArray = ConsoleLJFolderSetSurface(ArchitectureConsoleLJOneFirst.InputDirectory);

                var zee = (directoryArray.Length + 1);

                var array = new String[zee];

                array[0] = ArchitectureConsoleLJOneFirst.InputDirectory;

                Array.Copy(directoryArray, 0, array, 1, directoryArray.Length);

                directoryArray = array;
            }
            else
                "false".ToString();

            fileArray = ConsoleLJFileSetSurface(directoryArray);

            tuple = new Tuple<String[], String[]>(fileArray, directoryArray);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
