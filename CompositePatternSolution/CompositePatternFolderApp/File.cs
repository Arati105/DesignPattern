using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    public class File : IStorageItem
    {
        private string _name;
        private string _size;

        public File(string name,string size)
        {
            this._name = name;
            this._size = size;
        }
        

        public void display()
        {
            Console.WriteLine(" "+this._name+" | " +this._size);
            

        }

        
    }
}
