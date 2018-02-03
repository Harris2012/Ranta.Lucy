using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template.Utility
{
    partial class CSharp_Utility_Project_Template
    {
        public CSharp_Utility_Project_Template(CSharpUtilityProject project)
        {
            this.Project = project;
        }

        public CSharpUtilityProject Project { get; set; }
    }
}
