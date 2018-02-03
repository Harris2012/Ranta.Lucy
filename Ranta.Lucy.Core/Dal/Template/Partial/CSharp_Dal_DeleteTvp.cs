﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Dal.Template
{
    partial class CSharp_Dal_DeleteTvp
    {
        public CSharp_Dal_DeleteTvp(CSharpDalProject project, Table table)
        {
            this.Project = project;

            this.Table = table;
        }

        public CSharpDalProject Project { get; set; }

        public Table Table { get; set; }
    }
}
