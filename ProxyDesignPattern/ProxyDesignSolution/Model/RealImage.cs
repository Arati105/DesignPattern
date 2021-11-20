using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignSolution.Model
{
    public class RealImage : Image
    {
        private string _filename;

        public RealImage(string filename)
        {
            this._filename = filename;
            Console.WriteLine("Loading file:" + GetFileName());
        }

        public RealImage()
        {
        }

        public string GetFileName()
        {
            return _filename;
        }
        
      
        public void display()
        {

            Console.WriteLine("Displaying the filename:" + GetFileName());
            
        }
      
    }
}
