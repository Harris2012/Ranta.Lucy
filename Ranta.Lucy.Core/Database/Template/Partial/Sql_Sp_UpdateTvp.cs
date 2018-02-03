using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Database.Template
{
    partial class Sql_Sp_UpdateTvp
    {
        public Sql_Sp_UpdateTvp(Table table)
        {
            this.Table = table;
        }

        public Table Table { get; set; }
    }
}
