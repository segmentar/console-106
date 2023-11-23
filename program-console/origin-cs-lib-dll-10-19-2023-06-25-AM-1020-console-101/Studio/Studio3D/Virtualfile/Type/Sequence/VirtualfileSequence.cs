using Core;

namespace Core
{
    using System;

    public partial class VirtualfileSequence
    {
        public Virtualfile Result { get; set; } = default;

        public VirtualfileSequence(String Filename_VALUE, Byte[] Content_ARRAY, Boolean answer_DEBUG_is)
        {
            Debug(Filename_VALUE, Content_ARRAY, answer_DEBUG_is);

            Virtualfile virtualFile;

            virtualFile = new Virtualfile(Filename_VALUE, Content_ARRAY, answer_DEBUG_is);

            this.Result = virtualFile;

            return;
        }

        ~VirtualfileSequence()
        {
            return;
        }
    }
}
