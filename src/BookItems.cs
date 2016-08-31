﻿using System;
namespace Zhangyue.iReader.EBK2
{
    public class BookItems
    {
        private string _name = "";
        private int _index;
        private int _length;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        public int Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        public BookItems(string myname, int myindex, int mylength)
        {
            this._name = myname;
            this._index = myindex;
            this._length = mylength;
        }
    }
}
