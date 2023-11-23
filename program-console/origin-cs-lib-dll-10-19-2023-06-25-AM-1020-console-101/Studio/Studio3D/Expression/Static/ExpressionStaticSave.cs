using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expression
    {
        public static void Save(String item_PATH, Expression item_EXPRESSION)
        {
            if (File.Exists(item_PATH) is true)
            {
                File.Delete(item_PATH);
            }
            else
                "false".ToString();

            FileStream fileStream;

            fileStream = File.Create(item_PATH);

            using (fileStream)
            {
                var array = ExpressionModuleWrite.Collapse(item_EXPRESSION, true, true);

                fileStream.Write(array, 0, array.Length);

                fileStream.Close();

                fileStream.Dispose();
            }

            return;
        }
    }
}
