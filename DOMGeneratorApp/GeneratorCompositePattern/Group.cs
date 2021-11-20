using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorCompositePattern
{
    class Group:ITag
    {
        private string _tag1;
        private string _tag2;
        private List<ITag> list = new List<ITag>();

        public Group(string tag)
        {
            this._tag1 = tag;
        }
        public Group(string tag1, string tag2)
        {
            this._tag1 = tag1;
            this._tag2 = tag2;
        }
        public void AddTag(ITag t)
        {
            list.Add(t);
        }
        public string display(string htmlScript)
        {

            htmlScript += "<" + _tag1 + ">";
            if (_tag1 == "p")
                htmlScript += _tag2;
            foreach (ITag tag in list)
            {
                htmlScript = tag.display(htmlScript);
            }
            htmlScript += "</" + _tag1 + ">";
            return htmlScript;
        }
    }
}

