using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template.View
{
    partial class CSharp_View_CreateModel
    {
        public CSharp_View_CreateModel(CSharpWebProject project, Table table)
        {
            this.Project = project;

            this.Table = table;
        }

        public CSharpWebProject Project { get; set; }

        public Table Table { get; set; }
    }
}
