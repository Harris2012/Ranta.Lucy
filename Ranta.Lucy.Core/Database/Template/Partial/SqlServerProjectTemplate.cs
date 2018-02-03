using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Database.Template
{
    partial class SqlServerProjectTemplate
    {
        public SqlServerProjectTemplate(SqlServerProject project)
        {
            this.Project = project;
        }

        public SqlServerProject Project { get; set; }
    }
}
