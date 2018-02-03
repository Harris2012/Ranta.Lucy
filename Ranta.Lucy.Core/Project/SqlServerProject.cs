using System;
using System.Collections.Generic;

namespace Ranta.Lucy.Core
{
    public class SqlServerProject : ProjectBase
    {
        public string FullName
        {
            get { return string.Format("{0}.Database", this.Name); }
        }

        [Obsolete]
        public Dictionary<string, Schema> Schemas { get; set; }
    }
}
