using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core
{
    public class CSharpUtilityProject : CSharpProjectBase
    {
        public override string FullName
        {
            get
            {
                return string.Format("{0}.Utility", this.Name);
            }
        }
    }
}
