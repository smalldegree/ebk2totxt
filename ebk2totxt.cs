using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ebk2totxt
{
    class ebk2totxt
    {
        static void Main(string[] args)
        {
            const string book_name = "c:\\chaoyuepingyong.ebk2";
            
            StreamReader sr = new StreamReader(book_name);

            //while(!sr.EndOfStream)
            //{
            //    string temp = sr.ReadLine();
            
            //    if(temp != null)
            //    {
            //        Console.WriteLine(temp);
            //    }
            //}

            string array = sr.ReadToEnd();

        }
    }
}
