using System;
namespace Zhangyue.iReader.EBK2
{
    public class BytesToStruct
    {
        public static TextStruct BytesToTextStruct(byte[] bytes)
        {
            TextStruct result = default(TextStruct);
            int num = 0;
            result.book_id = BytesToStruct.GetInt32(4, ref num, bytes);
            result.head_data_size = BytesToStruct.GetInt16(2, ref num, bytes);
            result.ebk_version = BytesToStruct.GetInt16(2, ref num, bytes);
            result.ebk_size = BytesToStruct.GetInt32(4, ref num, bytes);
            result.book_name = BytesToStruct.GetBytes(64, ref num, bytes);
            result.file_size = BytesToStruct.GetInt32(4, ref num, bytes);
            result.head_compress_size = BytesToStruct.GetInt32(4, ref num, bytes);
            result.first_compress_block_size = BytesToStruct.GetInt32(4, ref num, bytes);
            result.chapter_count = BytesToStruct.GetInt16(2, ref num, bytes);
            result.compress_block_count = BytesToStruct.GetInt16(2, ref num, bytes);
            result.media_count = BytesToStruct.GetInt32(4, ref num, bytes);
            result.media_data_length = BytesToStruct.GetInt32(4, ref num, bytes);
            result.txt_compress_size = BytesToStruct.GetInt32(4, ref num, bytes);
            return result;
        }
        public static ChapterCompress BytesToChaptercompress(byte[] bytes)
        {
            ChapterCompress result = default(ChapterCompress);
            int num = 0;
            result.offset = BytesToStruct.GetInt32(4, ref num, bytes);
            result.length = BytesToStruct.GetInt32(4, ref num, bytes);
            return result;
        }
        public static ChapterStruct BytesToChapterStruct(byte[] bytes)
        {
            ChapterStruct result = default(ChapterStruct);
            int num = 0;
            result.chapter_name = BytesToStruct.GetBytes(64, ref num, bytes);
            result.offset = BytesToStruct.GetInt32(4, ref num, bytes);
            result.lenth = BytesToStruct.GetInt32(4, ref num, bytes);
            return result;
        }
        private static int GetInt32(int length, ref int offset, byte[] buff)
        {
            byte[] array = new byte[length];
            Array.Copy(buff, offset, array, 0, length);
            offset += length;
            return BitConverter.ToInt32(array, 0);
        }
        private static int GetInt16(int length, ref int offset, byte[] buff)
        {
            byte[] array = new byte[length];
            Array.Copy(buff, offset, array, 0, length);
            offset += length;
            return (int)BitConverter.ToInt16(array, 0);
        }
        private static byte[] GetBytes(int length, ref int offset, byte[] buff)
        {
            byte[] array = new byte[length];
            Array.Copy(buff, offset, array, 0, length);
            offset += length;
            return array;
        }
    }
}
