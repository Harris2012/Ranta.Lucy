using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core
{
    public class Schema
    {
        public string Name { get; set; }

        public List<Table> Tables { get; set; }
    }
}
