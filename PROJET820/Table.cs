using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET820
{
    class Table
    {
        public string Name { get; protected set; }
        public List<Attribute> AttrList { get; protected set; }

        public Table(string n)
        {
            Name = n;
            AttrList = new List<Attribute>();
        }

        public void AddAttribute(Attribute a)
        {
            AttrList.Add(a);
        }

    }
}
