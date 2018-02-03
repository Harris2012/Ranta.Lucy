using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ranta.Lucy.Business.Convertors;
using Ranta.Lucy.Business.Models;
using Ranta.Lucy.Business.Models.Design;
using Ranta.Lucy.Core.Dal.Template;
using Ranta.Lucy.Core.Database.Template;
using Ranta.Lucy.Utility;

namespace Ranta.Lucy.Business.Managers
{
    public class GenManager
    {
        SqlConnectionProvider connectionProvider;

        //ILog logger = LogManager.GetLogger(typeof(GenManager));

        public GenManager()
            : this(new SqlConnectionProvider())
        {
        }

        public GenManager(SqlConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }

        public void RunOnce(int designId)
        {

        }

        public string PreviewSql(string cmd, Table table)
        {
            var code = string.Empty;

            var coreTable = LucyConvertor.ToCoreTable(table);

            switch (cmd)
            {
                case "create":
                    var createtemplate = new Sql_CreateTable(coreTable);

                    code = createtemplate.TransformText();
                    break;
                case "tvp":
                    var tvptemplate = new Sql_CreateTvp(coreTable);

                    code = tvptemplate.TransformText();
                    break;
                case "insert":
                    var inserttemplate = new Sql_Sp_Insert(coreTable);

                    code = inserttemplate.TransformText();
                    break;
                case "update":
                    var updatetemplate = new Sql_Sp_Update(coreTable);

                    code = updatetemplate.TransformText();
                    break;
                case "delete":
                    var deletetemplate = new Sql_Sp_Delete(coreTable);

                    code = deletetemplate.TransformText();
                    break;
                case "get":
                    var gettemplate = new Sql_Sp_Get(coreTable);

                    code = gettemplate.TransformText();
                    break;
                case "inserttvp":
                    var inserttvptemplate = new Sql_Sp_InsertTvp(coreTable);

                    code = inserttvptemplate.TransformText();
                    break;
                case "updatetvp":
                    var updatetvptemplate = new Sql_Sp_UpdateTvp(coreTable);

                    code = updatetvptemplate.TransformText();
                    break;
                case "deletetvp":
                    var deletetvptemplate = new Sql_Sp_DeleteTvp(coreTable);

                    code = deletetvptemplate.TransformText();
                    break;
                case "gettvp":
                    var gettvptemplate = new Sql_Sp_GetTvp(coreTable);

                    code = gettvptemplate.TransformText();
                    break;
                default:
                    break;
            }

            return code;
        }

        public string PreviewDal(string cmd, string projectName, Table table)
        {
            var code = string.Empty;

            var coreTable = LucyConvertor.ToCoreTable(table);

            var project = LucyConvertor.ToCoreDalProject(projectName);

            switch (cmd)
            {
                case "insert":
                    var inserttemplate = new CSharp_Dal_Insert(project, coreTable);

                    code = inserttemplate.TransformText();
                    break;
                case "update":
                    var updatetemplate = new CSharp_Dal_Update(project, coreTable);

                    code = updatetemplate.TransformText();
                    break;
                case "delete":
                    var deletetemplate = new CSharp_Dal_Delete(project, coreTable);

                    code = deletetemplate.TransformText();
                    break;
                case "get":
                    var gettemplate = new CSharp_Dal_Get(project, coreTable);

                    code = gettemplate.TransformText();
                    break;
                case "inserttvp":
                    var inserttvptemplate = new CSharp_Dal_InsertTvp(project, coreTable);

                    code = inserttvptemplate.TransformText();
                    break;
                case "updatetvp":
                    var updatetvptemplate = new CSharp_Dal_UpdateTvp(project, coreTable);

                    code = updatetvptemplate.TransformText();
                    break;
                case "deletetvp":
                    var deletetvptemplate = new CSharp_Dal_DeleteTvp(project, coreTable);

                    code = deletetvptemplate.TransformText();
                    break;
                case "gettvp":
                    var gettvptemplate = new CSharp_Dal_GetTvp(project, coreTable);

                    code = gettvptemplate.TransformText();
                    break;
                default:
                    break;
            }

            return code;
        }
    }
}
