using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Database.Template
{
    partial class Sql_CreateTable
    {
        public Sql_CreateTable(Table table)
        {
            this.Table = table;
        }

        public Table Table { get; set; }
    }
}
