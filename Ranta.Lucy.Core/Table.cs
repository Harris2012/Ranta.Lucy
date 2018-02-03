using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core
{
    public class Table
    {
        public Schema Schema { get; set; }

        /// <summary>
        /// If Schema is null, take 'dbo' as SchemaName
        /// </summary>
        public string SchemaName
        {
            get
            {
                return Schema == null ? "dbo" : Schema.Name;
            }
        }

        public string Name { get; set; }

        public List<Field> Fields { get; set; }

        /// <summary>
        /// 在数据库脚本中使用
        /// <example>[Security].[Ternimal]</example>
        /// </summary>
        public string FullName
        {
            get
            {
                if (Schema == null)
                {
                    return string.Format("[dbo].[{0}]", Name);
                }
                else
                {
                    return string.Format("[{0}].[{1}]", this.Schema.Name, Name);
                }
            }
        }

        /// <summary>
        /// <example>Savory_Ternimal</example>
        /// </summary>
        public string UnderlineFullName
        {
            get
            {
                if (this.Schema == null)
                {
                    return Name;
                }
                else
                {
                    return string.Concat(this.Schema.Name, "_", Name);
                }
            }
        }

        public string DalEntity
        {
            get
            {
                if (this.Schema == null)
                {
                    return string.Format("{0}Entity", this.Name);
                }
                else
                {
                    return string.Format("{0}{1}Entity", this.Schema.Name, this.Name);
                }
            }
        }

        public string BusinessModel
        {
            get
            {
                if (this.Schema == null)
                {
                    return string.Format("{0}Model", this.Name);
                }
                else
                {
                    return string.Format("{0}{1}Model", this.Schema.Name, this.Name);
                }
            }
        }

        public string CsFullName
        {
            get
            {
                if (this.Schema == null)
                {
                    return this.Name;
                }
                else
                {
                    return string.Format("{0}{1}", this.Schema.Name, this.Name);
                }
            }
        }
    }
}
