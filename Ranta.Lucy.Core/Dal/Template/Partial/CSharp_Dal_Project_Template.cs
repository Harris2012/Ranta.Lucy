using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Dal.Template
{
    partial class CSharp_Dal_Project_Template
    {
        public CSharp_Dal_Project_Template(CSharpDalProject project, Dictionary<string, Table> tables)
        {
            this.Project = project;

            this.Tables = tables;
        }

        public CSharp_Dal_Project_Template(CSharpDalProject project, Dictionary<string, Schema> schemas)
        {
            this.Project = project;

            this.Schemas = schemas;
        }

        public CSharpDalProject Project { get; set; }

        public Dictionary<string, Table> Tables { get; set; }

        public Dictionary<string, Schema> Schemas { get; set; }
    }
}
