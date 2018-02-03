using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Core.Database
{
    public static class TableExtension
    {
        public static string SP_INSERT(this Table table)
        {
            return string.Format("[{0}].[Insert_{1}]", table.SchemaName, table.Name);
        }

        public static string SP_UPDATE(this Table table)
        {
            return string.Format("[{0}].[Update_{1}]", table.SchemaName, table.Name);
        }

        public static string SP_DELETE(this Table table)
        {
            return string.Format("[{0}].[Delete_{1}]", table.SchemaName, table.Name);
        }

        public static string SP_GET(this Table table)
        {
            return string.Format("[{0}].[Get_{1}]", table.SchemaName, table.Name);
        }

        public static string SP_QUERY(this Table table)
        {
            return string.Format("[{0}].[Query_{1}]", table.SchemaName, table.Name);
        }

        public static string SP_TVP_INSERT(this Table table)
        {
            return string.Format("[{0}].[InsertTvp_{1}]", table.SchemaName, table.Name);
        }

        public static string SP_TVP_UPDATE(this Table table)
        {
            return string.Format("[{0}].[UpdateTvp_{1}]", table.SchemaName, table.Name);
        }

        public static string SP_TVP_DELETE(this Table table)
        {
            return string.Format("[{0}].[DeleteTvp_{1}]", table.SchemaName, table.Name);
        }

        public static string TVP_NAME(this Table table)
        {
            return string.Format("[{0}].[Tvp_{1}]", table.SchemaName, table.Name);
        }

        public static string TVP_PARAM_NAME(this Table table)
        {
            return string.Format("Tvp_{0}_{1}", table.SchemaName, table.Name);
        }
    }
}
