using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorCompositePattern
{
    class Individual : ITag
    {
        private string _tag3;
        private string _tag4;

       public Individual(string t,string v)
        {
            this._tag3 = t;
            this._tag4 = v;
        }
       public string display(string htmlScript)
        {
            if (_tag3 == "input")
                return htmlScript + "<" + _tag3 + " type=\"" + _tag4 + "\">";
            return htmlScript + "<" + _tag3 + "/>";
        }
    }
}
