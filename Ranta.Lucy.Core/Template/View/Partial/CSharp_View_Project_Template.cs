using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template.View
{
    partial class CSharp_View_Project_Template
    {
        public CSharp_View_Project_Template(CSharpBusinessProject project)
        {
            this.Project = project;
        }

        public CSharpBusinessProject Project { get; set; }
    }
}
