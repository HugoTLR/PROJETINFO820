using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET820
{
    class Instance
    {

        public List<Table> TablesList { get; protected set; }

        public Instance()
        {
            TablesList = new List<Table>();
        }
    }
}
