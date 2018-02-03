using System;
using System.Collections.Generic;

namespace Ranta.Lucy.Core
{
    public class CSharpBusinessProject : CSharpProjectBase
    {
        public override string FullName
        {
            get
            {
                return string.Format("{0}.Business");
            }
        }

        [Obsolete]
        public Dictionary<string, Schema> Schemas { get; set; }

        public List<CSharpProjectBase> ReferencedProjects { get; set; }
    }
}
