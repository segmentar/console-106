using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ContributeModuleWriteLone
    {
        public static ContributeModuleWrite ModuleMemoryStream(ContributeModuleWrite module)
        {
            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(memoryStream, Contribute.WriterEncoding, true);

            Byte[]
                headerByteArray,
                tabulationByteArrayA, 
                tabulationByteArrayB,
                tabulationByteArrayC,
                tabulationByteArrayD
                ;

            headerByteArray = new Byte[0];

            tabulationByteArrayA = new Byte[0];

            tabulationByteArrayB = new Byte[0];

            tabulationByteArrayC = new Byte[0];

            tabulationByteArrayD = new Byte[0];

            Boolean
                isNotDefaultHeaderMemoryStream, 
                isNotDefaultTabulationMemoryStreamA,
                isNotDefaultTabulationMemoryStreamB,
                isNotDefaultTabulationMemoryStreamC,
                isNotDefaultTabulationMemoryStreamD
                ;

            isNotDefaultHeaderMemoryStream = (module.Streamline.HeaderMemoryStream == default) is false;

            isNotDefaultTabulationMemoryStreamA = (module.Streamline.MemoryStreamA == default) is false;

            isNotDefaultTabulationMemoryStreamB = (module.Streamline.MemoryStreamB == default) is false;

            isNotDefaultTabulationMemoryStreamC = (module.Streamline.MemoryStreamC == default) is false;

            isNotDefaultTabulationMemoryStreamD = (module.Streamline.MemoryStreamD == default) is false;

            if (isNotDefaultHeaderMemoryStream is true)
            {
                var array = module.Streamline.HeaderMemoryStream.ToArray();

                Array.Resize(ref headerByteArray, array.Length);

                array.CopyTo(headerByteArray, 0);
            }
            else
                "false".ToString();

            if (isNotDefaultTabulationMemoryStreamA is true)
            {
                var array = module.Streamline.MemoryStreamA.ToArray();

                Array.Resize(ref tabulationByteArrayA, array.Length);

                array.CopyTo(tabulationByteArrayA, 0);
            }
            else
                "false".ToString();

            if (isNotDefaultTabulationMemoryStreamB is true)
            {
                var array = module.Streamline.MemoryStreamB.ToArray();

                Array.Resize(ref tabulationByteArrayB, array.Length);

                array.CopyTo(tabulationByteArrayB, 0);
            }
            else
                "false".ToString();

            if (isNotDefaultTabulationMemoryStreamC is true)
            {
                var array = module.Streamline.MemoryStreamC.ToArray();

                Array.Resize(ref tabulationByteArrayC, array.Length);

                array.CopyTo(tabulationByteArrayC, 0);
            }
            else
                "false".ToString();

            if (isNotDefaultTabulationMemoryStreamD is true)
            {
                var array = module.Streamline.MemoryStreamD.ToArray();

                Array.Resize(ref tabulationByteArrayD, array.Length);

                array.CopyTo(tabulationByteArrayD, 0);
            }
            else
                "false".ToString();

            using (binaryWriter)
            {
                binaryWriter.Write(headerByteArray, 0, headerByteArray.Length);

                binaryWriter.BaseStream.Seek(module.FunctionHeader.TabulationTableAddressA, SeekOrigin.Begin);

                binaryWriter.Write(tabulationByteArrayA, 0, tabulationByteArrayA.Length);

                binaryWriter.BaseStream.Seek(module.FunctionHeader.TabulationTableAddressB, SeekOrigin.Begin);

                binaryWriter.Write(tabulationByteArrayB, 0, tabulationByteArrayB.Length);

                binaryWriter.BaseStream.Seek(module.FunctionHeader.TabulationTableAddressC, SeekOrigin.Begin);

                binaryWriter.Write(tabulationByteArrayC, 0, tabulationByteArrayC.Length);

                binaryWriter.BaseStream.Seek(module.FunctionHeader.TabulationTableAddressD, SeekOrigin.Begin);

                binaryWriter.Write(tabulationByteArrayD, 0, tabulationByteArrayD.Length);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }
            
            module.Streamline.MemoryStream = memoryStream;

            return module;
        }
    }
}
