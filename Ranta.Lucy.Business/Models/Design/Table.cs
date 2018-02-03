using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Business.Models.Design
{
    public class Table
    {
        public string Name { get; set; }

        public Dictionary<string, Field> Fields { get; set; }
    }
}
