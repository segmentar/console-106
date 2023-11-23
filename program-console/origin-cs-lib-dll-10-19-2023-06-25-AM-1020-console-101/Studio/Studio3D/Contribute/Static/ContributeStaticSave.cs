using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Linq;

    using System.Collections;

    public partial class Contribute
    {
        public static void Save(String item_PATH)
        {
            if (File.Exists(item_PATH) is true)
            {
                File.Delete(item_PATH);
            }
            else
                "false".ToString();

            IEnumerable enumerable;

            enumerable = ContributeArrayList.OfType<Contribute>().Cast<Contribute>().ToArray();

            var reflect = (Contribute[])(enumerable as Array);

            Contribute[] contributeArray;

            contributeArray = reflect;

            ContributeModuleWrite contributeModuleWrite = ContributeModuleWrite.ContributeModuleAction(contributeArray, true);

            FileStream fileStream;

            fileStream = File.Create(item_PATH);

            using (fileStream)
            {
                var array = contributeModuleWrite.Fourth.Function.ByteArray;

                fileStream.Write(array, 0, array.Length);

                fileStream.Flush();

                fileStream.Close();

                fileStream.Dispose();
            }

            return;
        }
    }
}
