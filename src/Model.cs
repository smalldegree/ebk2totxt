using System;
using System.Collections.Generic;
namespace Zhangyue.iReader.EBK2
{
    public class Model
    {
        public int CATHY_LZ77_WINDOW_SIZE = 65536;
        public List<string> correctchapterlist = new List<string>();
        public byte[] bookbuf;
        public int CATHYEBK_CHAPTER_NAME_MAX_SIZE = 64;
        public int CATHYEBK_TXT_FILE_MAX_SIZE = 10485760;
        public int CATHYEBK_VERSION = 2;
        public int CATHYEBK_NAME_MAX_SIZE = 64;
    }
}
