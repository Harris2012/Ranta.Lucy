using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template.Utility
{
    partial class SqlConnectionProvider
    {
        public SqlConnectionProvider(CSharpUtilityProject project)
        {
            this.Project = project;
        }

        public CSharpUtilityProject Project { get; set; }
    }
}
