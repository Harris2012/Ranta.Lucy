using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core
{
    public enum FieldType
    {
        NONE = 0,

        #region 精确数字
        BIT = 1,
        TINYINT = 2,
        SMALLINT = 3,
        INT = 4,
        BIGINT = 5,
        NUMERIC = 6,
        DECIMAL = 7,
        SMALLMONEY = 8,
        MONEY = 9,
        #endregion

        #region 近似数字
        FLOAT = 10,
        REAL = 11,
        #endregion

        #region 日期和时间
        DATETIME = 12,
        SMALLDATETIME = 13,
        DATE = 14,
        TIME = 15,
        DATETIMEOFFSET = 16,
        DATETIME2 = 17,
        #endregion

        #region 字符串
        CHAR = 18,
        VARCHAR = 19,
        TEXT = 20,
        #endregion

        #region Unicode 字符串
        NCHAR = 21,
        NVARCHAR = 22,
        NTEXT = 23,
        #endregion

        #region 二进制字符串
        BINARY = 24,
        VARBINARY = 25,
        IMAGE = 26,
        #endregion

        #region 其他数据类型
        SQL_VARIANT = 27,
        TIMESTAMP = 28,
        UNIQUEIDENTIFIER = 29,
        XML = 30,
        #endregion

        #region CLR数据类型
        HIERARCHYID = 31,
        #endregion

        #region 空间数据类型
        GEOMETRY = 32,
        GEOGRAPHY = 33
        #endregion
    }
}
