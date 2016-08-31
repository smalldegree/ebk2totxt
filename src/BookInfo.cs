using System;
using System.Collections.Generic;
namespace Zhangyue.iReader.EBK2
{
    public class BookInfo
    {
        private List<BookItems> _chapterlist = new List<BookItems>();
        private string _text = "";
        private byte[] _pic;
        private string _bookName;
        public List<BookItems> ChaterList
        {
            get
            {
                return this._chapterlist;
            }
            set
            {
                this._chapterlist = value;
            }
        }
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        public byte[] Picture
        {
            get
            {
                return this._pic;
            }
            set
            {
                this._pic = value;
            }
        }
        public string BookName
        {
            get
            {
                return this._bookName;
            }
            set
            {
                this._bookName = value;
            }
        }
    }
}
