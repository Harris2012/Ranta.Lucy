using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ranta.Lucy.Core.Template;
using System.Diagnostics;
using System.IO;
using Ranta.Lucy.Core.Template.Business;
using Ranta.Lucy.Core.Template.Utility;
using Ranta.Lucy.Core.Template.View;
using Ranta.Lucy.Core.Template.Solution;
using Ranta.Lucy.Core.Database.Template;
using Ranta.Lucy.Core.Dal.Template;
using Ranta.Lucy.Core.Template.AssemblyInfo;

namespace Ranta.Lucy.Core.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var solution = PrepareData();
            var solution = PrepareRealData();

            var schemas = GetSchema();

            var root = @"D:\TestSpace";

            var solutionFolder = Path.Combine(root, solution.Name);

            if (!Directory.Exists(solutionFolder))
            {
                Directory.CreateDirectory(solutionFolder);
            }

            #region Generate Files
            var solutionFilePath = Path.Combine(solutionFolder, string.Format("{0}.sln", solution.Name));
            var solutionContent = new SolutionTemplate(solution).TransformText();
            File.WriteAllText(solutionFilePath, solutionContent, Encoding.UTF8);

            if (solution.Projects != null && solution.Projects.Count > 0)
            {
                foreach (var project in solution.Projects)
                {
                    //Project Folder
                    var projectFolder = Path.Combine(solutionFolder, project.Name);
                    if (!Directory.Exists(projectFolder)) { Directory.CreateDirectory(projectFolder); }

                    //Project Properties Folder
                    var projectPropertiesFolder = Path.Combine(projectFolder, "Properties");
                    if (!Directory.Exists(projectPropertiesFolder)) { Directory.CreateDirectory(projectPropertiesFolder); }

                    var projectFilePath = string.Empty;
                    var projectContent = string.Empty;
                    var assemblyInfoPath = string.Empty;
                    var assemblyContent = string.Empty;
                    var modelFolder = string.Empty;

                    if (project is CSharpUtilityProject)
                    {
                        var utilityProject = project as CSharpUtilityProject;

                        #region Project Files
                        //Solution.Project.Business.csproj
                        projectFilePath = Path.Combine(projectFolder, string.Format("{0}.csproj", utilityProject.Name));
                        projectContent = new CSharp_Utility_Project_Template(utilityProject).TransformText();
                        File.WriteAllText(projectFilePath, projectContent, Encoding.UTF8);

                        //AssemblyInfo.cs
                        assemblyInfoPath = Path.Combine(projectPropertiesFolder, "AssemblyInfo.cs");
                        assemblyContent = new AssemblyInfoTemplate().TransformText();
                        File.WriteAllText(assemblyInfoPath, assemblyContent, Encoding.UTF8);
                        #endregion

                        #region SqlConnectionProvider
                        var sqlConnectionProviderFilePath = Path.Combine(projectFolder, "SqlConnectionProvider.cs");
                        var sqlConnectionProviderContent = new SqlConnectionProvider(utilityProject).TransformText();
                        File.WriteAllText(sqlConnectionProviderFilePath, sqlConnectionProviderContent, Encoding.UTF8);
                        #endregion
                    }
                    else if (project is CSharpBusinessProject)
                    {
                        var businessProject = project as CSharpBusinessProject;

                        #region Project Files
                        //Solution.Project.Business.csproj
                        projectFilePath = Path.Combine(projectFolder, string.Format("{0}.csproj", businessProject.Name));
                        projectContent = new CSharp_Business_Project_Template(businessProject).TransformText();
                        File.WriteAllText(projectFilePath, projectContent, Encoding.UTF8);

                        //AssemblyInfo.cs
                        assemblyInfoPath = Path.Combine(projectPropertiesFolder, "AssemblyInfo.cs");
                        assemblyContent = new AssemblyInfoTemplate().TransformText();
                        File.WriteAllText(assemblyInfoPath, assemblyContent, Encoding.UTF8);
                        #endregion

                        #region Model
                        //Model Folder
                        modelFolder = Path.Combine(projectFolder, "Models");
                        if (!Directory.Exists(modelFolder)) { Directory.CreateDirectory(modelFolder); }

                        //Models
                        foreach (var schema in businessProject.Schemas)
                        {
                            foreach (var table in schema.Value.Tables)
                            {
                                //Model File
                                var modelFilePath = Path.Combine(modelFolder, string.Format("{0}Model.cs", table.CsFullName));
                                var modelContent = new CSharp_Business_Model(businessProject, table).TransformText();
                                File.WriteAllText(modelFilePath, modelContent, Encoding.UTF8);
                            }
                        }
                        #endregion

                        #region Convertor
                        //Convertor Folder
                        var convertorFolder = Path.Combine(projectFolder, "Convertors");
                        if (!Directory.Exists(convertorFolder)) { Directory.CreateDirectory(convertorFolder); }

                        //Convertor
                        foreach (var schema in businessProject.Schemas)
                        {
                            foreach (var table in schema.Value.Tables)
                            {
                                var convertorFilePath = Path.Combine(convertorFolder, string.Format("{0}Convertor.cs", table.CsFullName));
                                var convertorContent = new CSharp_Business_Convertor(businessProject, table).TransformText();
                                File.WriteAllText(convertorFilePath, convertorContent, Encoding.UTF8);
                            }
                        }
                        #endregion

                        #region Manager
                        //Manager Folder
                        var managerFolder = Path.Combine(projectFolder, "Managers");
                        if (!Directory.Exists(managerFolder)) { Directory.CreateDirectory(managerFolder); }

                        //Manager Partial Folder
                        var emptyManagerFolder = Path.Combine(managerFolder, "Partial");
                        if (!Directory.Exists(emptyManagerFolder)) { Directory.CreateDirectory(emptyManagerFolder); }

                        //EntityManager
                        foreach (var schema in businessProject.Schemas)
                        {
                            foreach (var table in schema.Value.Tables)
                            {
                                //Generated Code
                                var managerFilePath = Path.Combine(emptyManagerFolder, string.Format("{0}Manager.cs", table.CsFullName));
                                var managerContent = new CSharp_Business_Manager(businessProject, table).TransformText();
                                File.WriteAllText(managerFilePath, managerContent);

                                //EmptyFile for user
                                var emptyManagerFilePath = Path.Combine(managerFolder, string.Format("{0}Manager.cs", table.CsFullName));
                                var emptyManagerContent = new CSharp_Business_Manager_Empty(businessProject, table).TransformText();
                                File.WriteAllText(emptyManagerFilePath, emptyManagerContent, Encoding.UTF8);
                            }
                        }
                        #endregion
                    }
                    else if (project is CSharpDalProject)
                    {
                        var dalProject = project as CSharpDalProject;

                        #region Dal Files
                        //Solution.Project.Dal.csproj
                        projectFilePath = Path.Combine(projectFolder, string.Format("{0}.csproj", dalProject.Name));
                        projectContent = new CSharp_Dal_Project_Template(dalProject, schemas).TransformText();
                        File.WriteAllText(projectFilePath, projectContent, Encoding.UTF8);

                        //AssemblyInfo.cs
                        assemblyInfoPath = Path.Combine(projectPropertiesFolder, "AssemblyInfo.cs");
                        assemblyContent = new AssemblyInfoTemplate().TransformText();
                        File.WriteAllText(assemblyInfoPath, assemblyContent, Encoding.UTF8);

                        foreach (var schema in schemas)
                        {
                            foreach (var table in schema.Value.Tables)
                            {
                                ////Table Folder
                                //var tableFolder = Path.Combine(projectFolder, table.CsFullName);
                                //if (!Directory.Exists(tableFolder)) { Directory.CreateDirectory(tableFolder); }

                                ////Entity
                                //var entityFilePath = Path.Combine(tableFolder, string.Format("{0}_Entity.cs", table.CsFullName));
                                //var entityContent = new CSharp_Dal_Entity(dalProject, table).TransformText();
                                //File.WriteAllText(entityFilePath, entityContent, Encoding.UTF8);

                                ////Query Param
                                //var queryParamFilePath = Path.Combine(tableFolder, string.Format("{0}_QueryParam.cs", table.CsFullName));
                                //var queryParamContent = new CSharp_Dal_QueryParam(dalProject, table).TransformText();
                                //File.WriteAllText(queryParamFilePath, queryParamContent, Encoding.UTF8);

                                ////Insert
                                //var insertFilePath = Path.Combine(tableFolder, string.Format("{0}_Insert.cs", table.CsFullName));
                                //var insertContent = new CSharp_Dal_Insert(dalProject, table).TransformText();
                                //File.WriteAllText(insertFilePath, insertContent, Encoding.UTF8);

                                ////InsertTvp
                                //var insertTvpFilePath = Path.Combine(tableFolder, string.Format("{0}_InsertTvp.cs", table.CsFullName));
                                //var insertTvpContent = new CSharp_Dal_InsertTvp(dalProject, table).TransformText();
                                //File.WriteAllText(insertTvpFilePath, insertTvpContent, Encoding.UTF8);

                                ////Update
                                //var updateFilePath = Path.Combine(tableFolder, string.Format("{0}_Update.cs", table.CsFullName));
                                //var updateContent = new CSharp_Dal_Update(dalProject, table).TransformText();
                                //File.WriteAllText(updateFilePath, updateContent, Encoding.UTF8);

                                ////UpdateTvp
                                //var updateTvpFilePath = Path.Combine(tableFolder, string.Format("{0}_UpdateTvp.cs", table.CsFullName));
                                //var updateTvpContent = new CSharp_Dal_UpdateTvp(dalProject, table).TransformText();
                                //File.WriteAllText(updateTvpFilePath, updateTvpContent, Encoding.UTF8);

                                ////Delete
                                //var deleteFilePath = Path.Combine(tableFolder, string.Format("{0}_Delete.cs", table.CsFullName));
                                //var deleteContent = new CSharp_Dal_Delete(dalProject, table).TransformText();
                                //File.WriteAllText(deleteFilePath, deleteContent, Encoding.UTF8);

                                ////DeleteTvp
                                //var deleteTvpFilePath = Path.Combine(tableFolder, string.Format("{0}_DeleteTvp.cs", table.CsFullName));
                                //var deleteTvpContent = new CSharp_Dal_DeleteTvp(dalProject, table).TransformText();
                                //File.WriteAllText(deleteTvpFilePath, deleteTvpContent, Encoding.UTF8);

                                ////Get
                                //var getFilePath = Path.Combine(tableFolder, string.Format("{0}_Get.cs", table.CsFullName));
                                //var getContent = new CSharp_Dal_Get(dalProject, table).TransformText();
                                //File.WriteAllText(getFilePath, getContent, Encoding.UTF8);

                                ////Query
                                //var queryFilePath = Path.Combine(tableFolder, string.Format("{0}_Query.cs", table.CsFullName));
                                //var queryContent = new CSharp_Dal_Query(dalProject, table).TransformText();
                                //File.WriteAllText(queryFilePath, queryContent, Encoding.UTF8);
                            }
                        }
                        #endregion
                    }
                    else if (project is SqlServerProject)
                    {
                        var sqlProject = project as SqlServerProject;

                        #region Sql Server Files
                        //Project.sqlproj
                        projectFilePath = Path.Combine(projectFolder, string.Format("{0}.sqlproj", project.Name));
                        projectContent = new SqlServerProjectTemplate(sqlProject).TransformText();
                        File.WriteAllText(projectFilePath, projectContent, Encoding.UTF8);

                        if (sqlProject.Schemas != null && sqlProject.Schemas.Count > 0)
                        {
                            foreach (var schema in sqlProject.Schemas)
                            {
                                //Schema Folder
                                var schemaFolder = Path.Combine(projectFolder, schema.Key);
                                if (!Directory.Exists(schemaFolder)) { Directory.CreateDirectory(schemaFolder); }

                                //Schema File
                                var schemaFilePath = Path.Combine(schemaFolder, string.Format("{0}.sql", schema.Key));
                                var schemaContent = new Sql_CreateSchema(schema.Key).TransformText();
                                File.WriteAllText(schemaFilePath, schemaContent, Encoding.UTF8);

                                //Schema Table Folder
                                var tableFolder = Path.Combine(schemaFolder, "Table");
                                if (!Directory.Exists(tableFolder)) { Directory.CreateDirectory(tableFolder); }
                                foreach (var table in schema.Value.Tables)
                                {
                                    //Table File
                                    var tableFilePath = Path.Combine(tableFolder, string.Format("{0}.sql", table.Name));
                                    var tableContent = new Sql_CreateTable(table).TransformText();
                                    File.WriteAllText(tableFilePath, tableContent);
                                }

                                //Schema TvpFolder
                                var tvpFolder = Path.Combine(schemaFolder, "Tvp");
                                if (!Directory.Exists(tvpFolder)) { Directory.CreateDirectory(tvpFolder); }
                                foreach (var table in schema.Value.Tables)
                                {
                                    //Tvp File
                                    var tvpFilePath = Path.Combine(tvpFolder, string.Format("Tvp_{0}.sql", table.Name));
                                    var tvpContent = new Sql_CreateTvp(table).TransformText();
                                    File.WriteAllText(tvpFilePath, tvpContent);
                                }

                                //Schema Stored Procedure Folder
                                var spFolder = Path.Combine(schemaFolder, "StoredProcedure");
                                if (!Directory.Exists(spFolder)) { Directory.CreateDirectory(spFolder); }
                                foreach (var table in schema.Value.Tables)
                                {
                                    var spTableFolder = Path.Combine(spFolder, table.UnderlineFullName);
                                    if (!Directory.Exists(spTableFolder)) { Directory.CreateDirectory(spTableFolder); }

                                    //Insert
                                    var spInsertFilePath = Path.Combine(spTableFolder, string.Format("SP_Insert_{0}.sql", table.UnderlineFullName));
                                    var spInsertContent = new Sql_Sp_Insert(table).TransformText();
                                    File.WriteAllText(spInsertFilePath, spInsertContent, Encoding.UTF8);

                                    //InsertTvp
                                    var spInsertTvpFilePath = Path.Combine(spTableFolder, string.Format("SP_InsertTvp_{0}.sql", table.UnderlineFullName));
                                    var spInsertTvpContent = new Sql_Sp_InsertTvp(table).TransformText();
                                    File.WriteAllText(spInsertTvpFilePath, spInsertTvpContent, Encoding.UTF8);

                                    //Update
                                    var spUpdateFilePath = Path.Combine(spTableFolder, string.Format("SP_Update_{0}.sql", table.UnderlineFullName));
                                    var spUpdateContent = new Sql_Sp_Update(table).TransformText();
                                    File.WriteAllText(spUpdateFilePath, spUpdateContent, Encoding.UTF8);

                                    //UpdateTvp
                                    var spUpdateTvpFilePath = Path.Combine(spTableFolder, string.Format("SP_UpdateTvp_{0}.sql", table.UnderlineFullName));
                                    var spUpdateTvpContent = new Sql_Sp_UpdateTvp(table).TransformText();
                                    File.WriteAllText(spUpdateTvpFilePath, spUpdateTvpContent, Encoding.UTF8);

                                    //Delete
                                    var spDeleteFilePath = Path.Combine(spTableFolder, string.Format("SP_Delete_{0}.sql", table.UnderlineFullName));
                                    var spDeleteContent = new Sql_Sp_Delete(table).TransformText();
                                    File.WriteAllText(spDeleteFilePath, spDeleteContent, Encoding.UTF8);

                                    //DeleteTvp
                                    var spDeleteTvpFilePath = Path.Combine(spTableFolder, string.Format("SP_DeleteTvp_{0}.sql", table.UnderlineFullName));
                                    var spDeleteTvpContent = new Sql_Sp_DeleteTvp(table).TransformText();
                                    File.WriteAllText(spDeleteTvpFilePath, spDeleteTvpContent, Encoding.UTF8);

                                    //Get
                                    var spGetFilePath = Path.Combine(spTableFolder, string.Format("SP_Get_{0}.sql", table.UnderlineFullName));
                                    var spGetContent = new Sql_Sp_Get(table).TransformText();
                                    File.WriteAllText(spGetFilePath, spGetContent, Encoding.UTF8);

                                    //Query
                                    var spQueryFilePath = Path.Combine(spTableFolder, string.Format("SP_Query_{0}.sql", table.UnderlineFullName));
                                    var spQueryContent = new Sql_Sp_Query(table).TransformText();
                                    File.WriteAllText(spQueryFilePath, spQueryContent, Encoding.UTF8);
                                }
                            }
                        }
                        #endregion
                    }
                }
            }
            #endregion
        }

        static Dictionary<string, Schema> GetSchema()
        {
            var schemas = new Dictionary<string, Schema>();

            var securitySchema = new Schema();

            securitySchema.Name = "Security";
            securitySchema.Tables = new List<Table>();

            var terminalTable = new Table();
            terminalTable.Name = "Terminal";
            terminalTable.Schema = securitySchema;
            terminalTable.Fields = new List<Field>();
            terminalTable.Fields.Add(new Field { Name = "Title", FieldType = FieldType.NVARCHAR, FieldSize = 50 });
            terminalTable.Fields.Add(new Field { Name = "Description", FieldType = FieldType.NVARCHAR, FieldSize = 50, Nullable = true });
            terminalTable.Fields.Add(new Field { Name = "Age", FieldType = FieldType.INT, Nullable = true });
            terminalTable.Fields.Add(new Field { Name = "SpaceTypeIds", FieldType = FieldType.INT, Multiple = true });
            terminalTable.Fields.Add(new Field { Name = "SpaceSizeId", FieldType = FieldType.INT });
            securitySchema.Tables.Add(terminalTable);

            var userTable = new Table();
            userTable.Name = "User";
            userTable.Schema = securitySchema;
            userTable.Fields = new List<Field>();
            userTable.Fields.Add(new Field { Name = "Name", FieldType = FieldType.NVARCHAR, FieldSize = 50 });
            userTable.Fields.Add(new Field { Name = "Sex", FieldType = FieldType.INT });
            userTable.Fields.Add(new Field { Name = "QQ", FieldType = FieldType.VARCHAR, FieldSize = 20 });
            userTable.Fields.Add(new Field { Name = "Address", FieldType = FieldType.NVARCHAR, FieldSize = 100 });
            userTable.Fields.Add(new Field { Name = "WeChat", FieldType = FieldType.VARCHAR, FieldSize = 20, Nullable = true });
            userTable.Fields.Add(new Field { Name = "Telephone", FieldType = FieldType.VARCHAR, FieldSize = 20, Nullable = true });
            userTable.Fields.Add(new Field { Name = "Mobile", FieldType = FieldType.VARCHAR, FieldSize = 20 });
            securitySchema.Tables.Add(userTable);

            schemas.Add("Security", securitySchema);

            return schemas;
        }

        static Dictionary<string, Schema> GetRealSchema()
        {
            var schemas = new Dictionary<string, Schema>();

            #region Schemas
            var securitySchema = new Schema();
            securitySchema.Name = "Security";
            securitySchema.Tables = new List<Table>();

            var lucySchema = new Schema();
            lucySchema.Name = "Lucy";
            lucySchema.Tables = new List<Table>();

            schemas.Add("Security", securitySchema);
            schemas.Add("Lucy", lucySchema);
            #endregion

            #region Tables
            var userTable = new Table();
            userTable.Name = "User";
            userTable.Fields = new List<Field>();
            userTable.Fields.Add(new Field { Name = "UserName", FieldType = FieldType.NVARCHAR, FieldSize = 20, Nullable = true });
            userTable.Fields.Add(new Field { Name = "NickName", FieldType = FieldType.NVARCHAR, FieldSize = 20, Nullable = true });
            userTable.Fields.Add(new Field { Name = "IsOauth", FieldType = FieldType.BIT });
            userTable.Fields.Add(new Field { Name = "DisplayOauthId", FieldType = FieldType.INT, Nullable = true });
            userTable.Fields.Add(new Field { Name = "EncryptedPassword", FieldType = FieldType.VARCHAR, FieldSize = 40, Nullable = true });
            userTable.Fields.Add(new Field { Name = "Email", FieldType = FieldType.NVARCHAR, FieldSize = 50, Nullable = true });
            userTable.Fields.Add(new Field { Name = "Telephone", FieldType = FieldType.VARCHAR, FieldSize = 20, Nullable = true });
            userTable.Fields.Add(new Field { Name = "QQ", FieldType = FieldType.VARCHAR, FieldSize = 20, Nullable = true });
            userTable.Fields.Add(new Field { Name = "WeChat", FieldType = FieldType.VARCHAR, FieldSize = 20, Nullable = true });
            userTable.Schema = securitySchema;
            securitySchema.Tables.Add(userTable);

            //Binding user and his oauth account.
            //Dependency between tables use primary key id.
            var userProfileTable = new Table();
            userProfileTable.Name = "UserProfile";
            userProfileTable.Fields = new List<Field>();
            userProfileTable.Fields.Add(new Field { Name = "UserId", FieldType = FieldType.INT });
            userProfileTable.Fields.Add(new Field { Name = "TencentId", FieldType = FieldType.INT, Nullable = true });
            userProfileTable.Fields.Add(new Field { Name = "SinaId", FieldType = FieldType.INT, Nullable = true });
            userProfileTable.Fields.Add(new Field { Name = "LiveId", FieldType = FieldType.INT, Nullable = true });
            userProfileTable.Fields.Add(new Field { Name = "DoubanId", FieldType = FieldType.INT, Nullable = true });
            userProfileTable.Schema = securitySchema;
            securitySchema.Tables.Add(userProfileTable);

            var antiCsrfTable = new Table();
            antiCsrfTable.Name = "AntiCsrf";
            antiCsrfTable.Fields = new List<Field>();
            antiCsrfTable.Fields.Add(new Field { Name = "CsrfCode", FieldType = FieldType.VARCHAR, FieldSize = 32 });
            antiCsrfTable.Fields.Add(new Field { Name = "MarkForDelete", FieldType = FieldType.BIT });
            antiCsrfTable.Schema = securitySchema;
            securitySchema.Tables.Add(antiCsrfTable);

            var oauthTable = new Table();
            oauthTable.Name = "TencentOauth";
            oauthTable.Fields = new List<Field>();
            oauthTable.Fields.Add(new Field { Name = "OpenId", FieldType = FieldType.VARCHAR, FieldSize = 32 });
            oauthTable.Fields.Add(new Field { Name = "AccessToken", FieldType = FieldType.VARCHAR, FieldSize = 32 });
            oauthTable.Fields.Add(new Field { Name = "RefreshToken", FieldType = FieldType.VARCHAR, FieldSize = 32 });
            oauthTable.Fields.Add(new Field { Name = "NickName", FieldType = FieldType.NVARCHAR, FieldSize = 20 });
            oauthTable.Fields.Add(new Field { Name = "Head40", FieldType = FieldType.VARCHAR, FieldSize = 100 });
            oauthTable.Fields.Add(new Field { Name = "Head100", FieldType = FieldType.VARCHAR, FieldSize = 100 });
            oauthTable.Schema = securitySchema;
            securitySchema.Tables.Add(oauthTable);

            var projectTable = new Table();
            projectTable.Name = "Project";
            projectTable.Fields = new List<Field>();
            projectTable.Fields.Add(new Field { Name = "Name", FieldType = FieldType.NVARCHAR, FieldSize = 50 });
            projectTable.Fields.Add(new Field { Name = "OwnerId", FieldType = FieldType.INT });
            projectTable.Schema = lucySchema;
            lucySchema.Tables.Add(projectTable);

            var designTable = new Table();
            designTable.Name = "Design";
            designTable.Fields = new List<Field>();
            designTable.Fields.Add(new Field { Name = "ProjectId", FieldType = FieldType.INT });
            designTable.Fields.Add(new Field { Name = "Data", FieldType = FieldType.VARCHAR, FieldSize = 8000 });
            designTable.Schema = lucySchema;
            lucySchema.Tables.Add(designTable);
            #endregion

            return schemas;
        }

        static SolutionMetadata PrepareRealData()
        {
            SolutionMetadata solution = new SolutionMetadata();

            solution.Name = "Ranta";
            solution.Guid = Guid.NewGuid();

            solution.Projects = new List<ProjectBase>();

            //Database
            SqlServerProject sqlProjectMetadata = new SqlServerProject();
            sqlProjectMetadata.Name = "Lucy";
            sqlProjectMetadata.ProjectGuid = new Guid();
            solution.Projects.Add(sqlProjectMetadata);

            //Dal
            CSharpDalProject projectDalMeta = new CSharpDalProject();
            projectDalMeta.Name = "Lucy";
            projectDalMeta.ProjectGuid = Guid.NewGuid();
            solution.Projects.Add(projectDalMeta);

            //Utility
            CSharpUtilityProject projectUtilityMeta = new CSharpUtilityProject();
            projectUtilityMeta.Name = "Lucy";
            projectUtilityMeta.ProjectGuid = Guid.NewGuid();
            solution.Projects.Add(projectUtilityMeta);

            //Business
            CSharpBusinessProject projectBusinessMeta = new CSharpBusinessProject();
            projectBusinessMeta.Name = "Lucy";
            projectBusinessMeta.ProjectGuid = Guid.NewGuid();
            projectBusinessMeta.ReferencedProjects = new List<CSharpProjectBase>();
            projectBusinessMeta.ReferencedProjects.Add(projectDalMeta);
            projectBusinessMeta.ReferencedProjects.Add(projectUtilityMeta);
            solution.Projects.Add(projectBusinessMeta);

            return solution;
        }

        static SolutionMetadata PrepareData()
        {
            SolutionMetadata solution = new SolutionMetadata();
            solution.Name = "Savory";
            solution.Guid = Guid.NewGuid();

            #region Projects
            solution.Projects = new List<ProjectBase>();

            //Database
            SqlServerProject sqlProjectMetadata = new SqlServerProject();
            sqlProjectMetadata.Name = "Lucy";
            sqlProjectMetadata.ProjectGuid = new Guid();
            solution.Projects.Add(sqlProjectMetadata);

            //Dal
            CSharpDalProject projectDalMeta = new CSharpDalProject();

            projectDalMeta.Name = "Terminal";
            projectDalMeta.ProjectGuid = Guid.NewGuid();
            solution.Projects.Add(projectDalMeta);

            //Utility
            CSharpUtilityProject projectUtilityMeta = new CSharpUtilityProject();
            projectUtilityMeta.Name = "Terminal";
            projectUtilityMeta.ProjectGuid = Guid.NewGuid();
            solution.Projects.Add(projectUtilityMeta);

            //Business
            CSharpBusinessProject projectBusinessMeta = new CSharpBusinessProject();
            projectBusinessMeta.Name = "Terminal";
            projectBusinessMeta.ProjectGuid = Guid.NewGuid();
            projectBusinessMeta.ReferencedProjects = new List<CSharpProjectBase>();
            projectBusinessMeta.ReferencedProjects.Add(projectDalMeta);
            projectBusinessMeta.ReferencedProjects.Add(projectUtilityMeta);

            solution.Projects.Add(projectBusinessMeta);


            #endregion

            return solution;
        }
    }
}
