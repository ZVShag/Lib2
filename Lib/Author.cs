using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    internal class Author
    {
        public int Id;
        public string FName;
        public string SName;

        public Author()
        {
            Id = 0;
            FName = "";
            SName = "";
        }
        public Author(int id, string fName, string sName)
        {
            Id = id;
            FName = fName;
            SName = sName;
        }
    }
}
