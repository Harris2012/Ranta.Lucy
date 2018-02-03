using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template.Business
{
    partial class CSharp_Business_Project_Template
    {
        public CSharp_Business_Project_Template(CSharpBusinessProject project)
        {
            this.Project = project;
        }

        public CSharpBusinessProject Project { get; set; }
    }
}
