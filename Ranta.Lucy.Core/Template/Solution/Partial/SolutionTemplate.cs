using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template.Solution
{
    partial class SolutionTemplate
    {
        public SolutionTemplate(SolutionMetadata solution)
        {
            this.Guid = solution.Guid;

            this.Projects = solution.Projects;
        }

        public Guid Guid { get; set; }

        public List<ProjectBase> Projects { get; set; }
    }
}
