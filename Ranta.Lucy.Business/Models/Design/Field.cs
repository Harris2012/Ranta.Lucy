using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Business.Models.Design
{
    public class Field
    {
        public string Name { get; set; }

        public FieldType FieldType { get; set; }

        public int FieldSize { get; set; }

        public bool Nullable { get; set; }

        public bool Multiple { get; set; }
    }
}
