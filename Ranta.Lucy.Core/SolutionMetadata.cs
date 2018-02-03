using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template
{
    public class SolutionMetadata
    {
        /// <summary>
        /// <example>Savory</example>
        /// </summary>
        public string Name { get; set; }

        public Guid Guid { get; set; }

        /// <summary>
        /// Projects in solution
        /// </summary>
        public List<ProjectBase> Projects { get; set; }
    }
}
