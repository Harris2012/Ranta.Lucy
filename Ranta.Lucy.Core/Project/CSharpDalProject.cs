using System;
using System.Collections.Generic;

namespace Ranta.Lucy.Core
{
    public class CSharpDalProject : CSharpProjectBase
    {
        public override string FullName
        {
            get
            {
                return string.Format("{0}.Dal", this.Name);
            }
        }

        public List<CSharpProjectBase> ReferencedProjects { get; set; }
    }
}
