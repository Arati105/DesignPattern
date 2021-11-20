using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignSolution.Model
{
    public class ProxyImage : Image
    {
        private string _fileName;
        private RealImage realImage;

        public ProxyImage(string filename)
        {
            this._fileName = filename;
            Console.WriteLine("Loading file:" + filename);
        }
        public string FileName
        {
            get
            {
                return _fileName;
            }
        }
        public void display()
        {
            Console.WriteLine("Displaying the filename:" + FileName);
           if(realImage == null)
            {
                realImage = new RealImage();
            }
            realImage.display();
        }
    }
}
