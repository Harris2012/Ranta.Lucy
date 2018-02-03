using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Database.Template
{
    partial class Sql_CreateSchema
    {
        public Sql_CreateSchema(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
