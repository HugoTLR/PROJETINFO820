using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET820
{
    class Attribute
    { 
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public bool Primary { get; protected set; }

        public Attribute(string n,string t, bool b = false)
        {
            Name = n;
            Type = t;
            Primary = b;
        }
    }
}
