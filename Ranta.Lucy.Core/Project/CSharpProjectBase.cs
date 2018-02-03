using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core
{
    public abstract class CSharpProjectBase : ProjectBase
    {
        public abstract string FullName
        {
            get;
        }
    }
}
