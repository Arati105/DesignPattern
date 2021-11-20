using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
    class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> childern = new List<IStorageItem>();

        public Folder(string name)
        {
            this._name = name;
        }
       public void AddChild(IStorageItem storage)
        {
            childern.Add(storage);
        }
        public void Display()
        {
           
        }
         public void display()
        {
            Console.WriteLine(this._name);
            foreach (IStorageItem storageItem in childern)
            {
                storageItem.display();
            }
        }
    }
}
