using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core
{
    public abstract class ProjectBase
    {
        public string Name { get; set; }

        public Guid ProjectGuid { get; set; }
    }
}
