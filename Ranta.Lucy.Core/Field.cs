using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core
{
    /// <summary>
    /// text, ntext, and image data types are invalid for local variables.
    /// </summary>
    public class Field
    {
        public string Name { get; set; }

        public FieldType FieldType { get; set; }

        public bool Nullable { get; set; }

        public int FieldSize { get; set; }

        //是否是多选项
        public bool Multiple { get; set; }

        //数据库中字段的全类型，例如 NVARCHAR(50)
        public string FullType
        {
            get
            {
                var fieldType = string.Empty;
                switch (this.FieldType)
                {
                    case FieldType.TINYINT:
                    case FieldType.SMALLINT:
                    case FieldType.BIGINT:
                    case FieldType.INT:
                    case FieldType.BIT:
                    case FieldType.DATETIME:
                    case FieldType.SMALLDATETIME:
                    case FieldType.DATE:
                    case FieldType.TIME:
                    case FieldType.DATETIMEOFFSET:
                    case FieldType.DATETIME2:
                    case FieldType.TEXT:
                    case FieldType.NTEXT:
                    case FieldType.FLOAT:
                    case FieldType.REAL:
                    case FieldType.DECIMAL:
                    case FieldType.SMALLMONEY:
                    case FieldType.MONEY:
                    case FieldType.BINARY:
                    case FieldType.VARBINARY:
                    case FieldType.IMAGE:
                    case FieldType.SQL_VARIANT:
                    case FieldType.TIMESTAMP:
                    case FieldType.UNIQUEIDENTIFIER:
                    case FieldType.XML:
                    case FieldType.HIERARCHYID:
                    case FieldType.GEOMETRY:
                    case FieldType.GEOGRAPHY:
                        fieldType = this.FieldType.ToString();
                        break;

                    case FieldType.CHAR:
                    case FieldType.NCHAR:
                    case FieldType.VARCHAR:
                    case FieldType.NVARCHAR:
                        fieldType = string.Format("{0}({1})", this.FieldType, this.FieldSize);
                        break;

                    case FieldType.NUMERIC:
                        if (this.FieldSize == 0)
                        {
                            fieldType = this.FieldType.ToString();
                        }
                        else
                        {
                            fieldType = string.Format("{0}({1})", this.FieldType, this.FieldSize);
                        }
                        break;

                    case FieldType.NONE:
                    default:
                        break;
                }

                return fieldType;
            }
        }

        //C#属性的类型
        public string PropertyType
        {
            get
            {
                var propertyType = string.Empty;
                switch (this.FieldType)
                {
                    case FieldType.TINYINT:
                        propertyType = "System.Byte";
                        break;
                    case FieldType.SMALLINT:
                        propertyType = "System.Int16";
                        break;
                    case FieldType.INT:
                        propertyType = "System.Int32";
                        break;
                    case FieldType.BIGINT:
                        propertyType = "System.Int64";
                        break;
                    case FieldType.BIT:
                        propertyType = "System.Boolean";
                        break;
                    case FieldType.NUMERIC:
                    case FieldType.DECIMAL:
                    case FieldType.SMALLMONEY:
                    case FieldType.MONEY:
                        propertyType = "System.Decimal";
                        break;
                    case FieldType.FLOAT:
                        propertyType = "System.Double";
                        break;
                    case FieldType.REAL:
                        propertyType = "System.Single";
                        break;
                    case FieldType.SMALLDATETIME:
                    case FieldType.DATETIME:
                    case FieldType.DATE:
                    case FieldType.TIME:
                    case FieldType.DATETIMEOFFSET:
                    case FieldType.DATETIME2:
                        propertyType = "System.DateTime";
                        break;
                    case FieldType.CHAR:
                    case FieldType.NCHAR:
                    case FieldType.NVARCHAR:
                    case FieldType.VARCHAR:
                    case FieldType.TEXT:
                    case FieldType.NTEXT:
                        propertyType = "System.String";
                        break;
                    case FieldType.BINARY:
                    case FieldType.VARBINARY:
                    case FieldType.IMAGE:
                        propertyType = "System.Byte[]";
                        break;
                    case FieldType.TIMESTAMP:
                        propertyType = "System.DateTime";
                        break;
                    case FieldType.UNIQUEIDENTIFIER:
                        propertyType = "System.Guid";
                        break;

                    case FieldType.XML:
                        break;
                    case FieldType.SQL_VARIANT:
                        break;
                    case FieldType.HIERARCHYID:
                        break;
                    case FieldType.GEOMETRY:
                        break;
                    case FieldType.GEOGRAPHY:
                        break;
                    case FieldType.NONE:
                    default:
                        break;
                }

                return propertyType;
            }
        }

        //C#中该类型是否是引用类型，例如string就是引用类型
        public bool IsReferenceType
        {
            get
            {
                var isReferenceType = false;
                switch (this.FieldType)
                {
                    case FieldType.CHAR:
                    case FieldType.NCHAR:
                    case FieldType.NVARCHAR:
                    case FieldType.VARCHAR:
                    case FieldType.TEXT:
                    case FieldType.NTEXT:
                        isReferenceType = true;
                        break;

                    case FieldType.TINYINT:
                    case FieldType.SMALLINT:
                    case FieldType.INT:
                    case FieldType.BIGINT:
                    case FieldType.BIT:
                    case FieldType.NUMERIC:
                    case FieldType.DECIMAL:
                    case FieldType.SMALLMONEY:
                    case FieldType.MONEY:
                    case FieldType.FLOAT:
                    case FieldType.REAL:
                    case FieldType.SMALLDATETIME:
                    case FieldType.DATETIME:
                    case FieldType.DATE:
                    case FieldType.TIME:
                    case FieldType.DATETIMEOFFSET:
                    case FieldType.DATETIME2:
                    case FieldType.TIMESTAMP:
                    case FieldType.UNIQUEIDENTIFIER:
                        isReferenceType = false;
                        break;

                    case FieldType.BINARY:
                    case FieldType.VARBINARY:
                    case FieldType.IMAGE:
                        isReferenceType = true;
                        break;

                    case FieldType.XML:
                        break;
                    case FieldType.SQL_VARIANT:
                        break;
                    case FieldType.HIERARCHYID:
                        break;
                    case FieldType.GEOMETRY:
                        break;
                    case FieldType.GEOGRAPHY:
                        break;
                    case FieldType.NONE:
                    default:
                        break;
                }
                return isReferenceType;
            }
        }

        public string ConvertMethod
        {
            get
            {
                var method = string.Empty;
                switch (this.FieldType)
                {
                    case FieldType.TINYINT:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToByte(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToByte(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.SMALLINT:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToInt16(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToInt16(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.INT:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToInt32(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.BIGINT:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToInt64(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToInt64(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.BIT:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToBoolean(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToBoolean(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.NUMERIC:
                    case FieldType.DECIMAL:
                    case FieldType.SMALLMONEY:
                    case FieldType.MONEY:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToDecimal(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToDecimal(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.FLOAT:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToDouble(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToDouble(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.REAL:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToSingle(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToSingle(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.SMALLDATETIME:
                    case FieldType.DATETIME:
                    case FieldType.DATE:
                    case FieldType.TIME:
                    case FieldType.DATETIMEOFFSET:
                    case FieldType.DATETIME2:
                    case FieldType.TIMESTAMP:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? (int?)null : Convert.ToDateTime(reader[\"{0}\"])", this.Name);
                        }
                        else
                        {
                            method = string.Format("Convert.ToDateTime(reader[\"{0}\"])", this.Name);
                        }
                        break;
                    case FieldType.CHAR:
                    case FieldType.NCHAR:
                    case FieldType.NVARCHAR:
                    case FieldType.VARCHAR:
                    case FieldType.TEXT:
                    case FieldType.NTEXT:
                        if (this.Nullable)
                        {
                            method = string.Format("reader[\"{0}\"] == DBNull.Value ? null : reader[\"{0}\"].ToString()", this.Name);
                        }
                        else
                        {
                            method = string.Format("reader[\"{0}\"].ToString()", this.Name);
                        }
                        break;
                    case FieldType.BINARY:
                    case FieldType.VARBINARY:
                    case FieldType.IMAGE:
                        //propertyType = "System.Byte[]";
                        break;

                    case FieldType.UNIQUEIDENTIFIER:
                        //propertyType = "System.Guid";
                        break;

                    case FieldType.XML:
                        break;
                    case FieldType.SQL_VARIANT:
                        break;
                    case FieldType.HIERARCHYID:
                        break;
                    case FieldType.GEOMETRY:
                        break;
                    case FieldType.GEOGRAPHY:
                        break;
                    case FieldType.NONE:
                    default:
                        break;
                }

                return method;
            }
        }
    }
}
