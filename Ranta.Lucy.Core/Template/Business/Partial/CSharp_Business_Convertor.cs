﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Template.Business
{
    partial class CSharp_Business_Convertor
    {
        public CSharp_Business_Convertor(CSharpBusinessProject project, Table table)
        {
            this.Project = project;

            this.Table = table;
        }

        public CSharpBusinessProject Project { get; set; }

        public Table Table { get; set; }
    }
}
