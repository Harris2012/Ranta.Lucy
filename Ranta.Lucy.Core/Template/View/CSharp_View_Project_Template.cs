﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 14.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Ranta.Lucy.Core.Template.View
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CSharp_View_Project_Template : CSharp_View_Project_TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""12.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{");
            
            #line 15 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.ProjectGuid.ToString()));
            
            #line default
            #line hidden
            this.Write("}</ProjectGuid>\r\n    <ProjectTypeGuids>{E3E379DF-F4C6-4180-9B81-6769533ABE47};{34" +
                    "9c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</Proj" +
                    "ectTypeGuids>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>Ranta.Lucy</RootNamespace>\r\n    <" +
                    "AssemblyName>Ranta.Lucy</AssemblyName>\r\n    <TargetFrameworkVersion>v4.0</Target" +
                    "FrameworkVersion>\r\n    <MvcBuildViews>false</MvcBuildViews>\r\n    <UseIISExpress>" +
                    "true</UseIISExpress>\r\n    <IISExpressSSLPort />\r\n    <IISExpressAnonymousAuthent" +
                    "ication />\r\n    <IISExpressWindowsAuthentication />\r\n    <IISExpressUseClassicPi" +
                    "pelineMode />\r\n    <SccProjectName>SAK</SccProjectName>\r\n    <SccLocalPath>SAK</" +
                    "SccLocalPath>\r\n    <SccAuxPath>SAK</SccAuxPath>\r\n    <SccProvider>SAK</SccProvid" +
                    "er>\r\n    <WebGreaseLibPath>..\\packages\\WebGrease.1.5.2\\lib</WebGreaseLibPath>\r\n " +
                    " </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Configuration)|$(Platform)\' =" +
                    "= \'Debug|AnyCPU\' \">\r\n    <DebugSymbols>true</DebugSymbols>\r\n    <DebugType>full<" +
                    "/DebugType>\r\n    <Optimize>false</Optimize>\r\n    <OutputPath>bin\\</OutputPath>\r\n" +
                    "    <DefineConstants>DEBUG;TRACE</DefineConstants>\r\n    <ErrorReport>prompt</Err" +
                    "orReport>\r\n    <WarningLevel>4</WarningLevel>\r\n  </PropertyGroup>\r\n  <PropertyGr" +
                    "oup Condition=\" \'$(Configuration)|$(Platform)\' == \'Release|AnyCPU\' \">\r\n    <Debu" +
                    "gType>pdbonly</DebugType>\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>bin\\</" +
                    "OutputPath>\r\n    <DefineConstants>TRACE</DefineConstants>\r\n    <ErrorReport>prom" +
                    "pt</ErrorReport>\r\n    <WarningLevel>4</WarningLevel>\r\n  </PropertyGroup>\r\n  <Ite" +
                    "mGroup>\r\n    <Reference Include=\"Antlr3.Runtime\">\r\n      <HintPath>..\\packages\\A" +
                    "ntlr.3.4.1.9004\\lib\\Antlr3.Runtime.dll</HintPath>\r\n    </Reference>\r\n    <Refere" +
                    "nce Include=\"log4net\">\r\n      <HintPath>..\\packages\\log4net.2.0.3\\lib\\net40-full" +
                    "\\log4net.dll</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"Microsoft.CSh" +
                    "arp\" />\r\n    <Reference Include=\"Newtonsoft.Json, Version=6.0.0.0, Culture=neutr" +
                    "al, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL\">\r\n      <Specif" +
                    "icVersion>False</SpecificVersion>\r\n      <HintPath>..\\packages\\Newtonsoft.Json.6" +
                    ".0.8\\lib\\net40\\Newtonsoft.Json.dll</HintPath>\r\n    </Reference>\r\n    <Reference " +
                    "Include=\"System\" />\r\n    <Reference Include=\"System.Data\" />\r\n    <Reference Inc" +
                    "lude=\"System.Drawing\" />\r\n    <Reference Include=\"System.Web.DynamicData\" />\r\n  " +
                    "  <Reference Include=\"System.Web.Entity\" />\r\n    <Reference Include=\"System.Web." +
                    "ApplicationServices\" />\r\n    <Reference Include=\"System.ComponentModel.DataAnnot" +
                    "ations\" />\r\n    <Reference Include=\"System.Core\" />\r\n    <Reference Include=\"Sys" +
                    "tem.Data.DataSetExtensions\" />\r\n    <Reference Include=\"System.Web.Optimization\"" +
                    ">\r\n      <HintPath>..\\packages\\Microsoft.AspNet.Web.Optimization.1.1.3\\lib\\net40" +
                    "\\System.Web.Optimization.dll</HintPath>\r\n    </Reference>\r\n    <Reference Includ" +
                    "e=\"System.Xml.Linq\" />\r\n    <Reference Include=\"System.Web\" />\r\n    <Reference I" +
                    "nclude=\"System.Web.Extensions\" />\r\n    <Reference Include=\"System.Web.Abstractio" +
                    "ns\" />\r\n    <Reference Include=\"System.Web.Routing\" />\r\n    <Reference Include=\"" +
                    "System.Xml\" />\r\n    <Reference Include=\"System.Configuration\" />\r\n    <Reference" +
                    " Include=\"System.Web.Services\" />\r\n    <Reference Include=\"System.EnterpriseServ" +
                    "ices\" />\r\n    <Reference Include=\"Microsoft.Web.Infrastructure, Version=1.0.0.0," +
                    " Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL\">\r" +
                    "\n      <Private>True</Private>\r\n      <HintPath>..\\packages\\Microsoft.Web.Infras" +
                    "tructure.1.0.0.0\\lib\\net40\\Microsoft.Web.Infrastructure.dll</HintPath>\r\n    </Re" +
                    "ference>\r\n    <Reference Include=\"Microsoft.Web.Mvc.FixedDisplayModes, Version=1" +
                    ".0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=" +
                    "MSIL\">\r\n      <Private>True</Private>\r\n      <HintPath>..\\packages\\Microsoft.Asp" +
                    "Net.Mvc.FixedDisplayModes.1.0.0\\lib\\net40\\Microsoft.Web.Mvc.FixedDisplayModes.dl" +
                    "l</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"System.Net.Http\">\r\n     " +
                    " <Private>True</Private>\r\n      <HintPath>..\\packages\\Microsoft.Net.Http.2.0.305" +
                    "06.0\\lib\\net40\\System.Net.Http.dll</HintPath>\r\n    </Reference>\r\n    <Reference " +
                    "Include=\"System.Net.Http.Formatting, Version=4.0.0.0, Culture=neutral, PublicKey" +
                    "Token=31bf3856ad364e35, processorArchitecture=MSIL\">\r\n      <HintPath>..\\package" +
                    "s\\Microsoft.AspNet.WebApi.Client.4.0.30506.0\\lib\\net40\\System.Net.Http.Formattin" +
                    "g.dll</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"System.Net.Http.WebR" +
                    "equest\">\r\n      <Private>True</Private>\r\n      <HintPath>..\\packages\\Microsoft.N" +
                    "et.Http.2.0.30506.0\\lib\\net40\\System.Net.Http.WebRequest.dll</HintPath>\r\n    </R" +
                    "eference>\r\n    <Reference Include=\"System.Web.Helpers, Version=2.0.0.0, Culture=" +
                    "neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL\">\r\n      <P" +
                    "rivate>True</Private>\r\n      <HintPath>..\\packages\\Microsoft.AspNet.WebPages.2.0" +
                    ".30506.0\\lib\\net40\\System.Web.Helpers.dll</HintPath>\r\n    </Reference>\r\n    <Ref" +
                    "erence Include=\"System.Web.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToke" +
                    "n=31bf3856ad364e35, processorArchitecture=MSIL\">\r\n      <HintPath>..\\packages\\Mi" +
                    "crosoft.AspNet.WebApi.Core.4.0.30506.0\\lib\\net40\\System.Web.Http.dll</HintPath>\r" +
                    "\n    </Reference>\r\n    <Reference Include=\"System.Web.Http.WebHost, Version=4.0." +
                    "0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSI" +
                    "L\">\r\n      <HintPath>..\\packages\\Microsoft.AspNet.WebApi.WebHost.4.0.30506.0\\lib" +
                    "\\net40\\System.Web.Http.WebHost.dll</HintPath>\r\n    </Reference>\r\n    <Reference " +
                    "Include=\"System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf38" +
                    "56ad364e35, processorArchitecture=MSIL\">\r\n      <Private>True</Private>\r\n      <" +
                    "HintPath>..\\packages\\Microsoft.AspNet.Mvc.4.0.30506.0\\lib\\net40\\System.Web.Mvc.d" +
                    "ll</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"System.Web.Razor, Versi" +
                    "on=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitect" +
                    "ure=MSIL\">\r\n      <Private>True</Private>\r\n      <HintPath>..\\packages\\Microsoft" +
                    ".AspNet.Razor.2.0.30506.0\\lib\\net40\\System.Web.Razor.dll</HintPath>\r\n    </Refer" +
                    "ence>\r\n    <Reference Include=\"System.Web.WebPages, Version=2.0.0.0, Culture=neu" +
                    "tral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL\">\r\n      <Priv" +
                    "ate>True</Private>\r\n      <HintPath>..\\packages\\Microsoft.AspNet.WebPages.2.0.30" +
                    "506.0\\lib\\net40\\System.Web.WebPages.dll</HintPath>\r\n    </Reference>\r\n    <Refer" +
                    "ence Include=\"System.Web.WebPages.Deployment, Version=2.0.0.0, Culture=neutral, " +
                    "PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL\">\r\n      <Private>Tr" +
                    "ue</Private>\r\n      <HintPath>..\\packages\\Microsoft.AspNet.WebPages.2.0.30506.0\\" +
                    "lib\\net40\\System.Web.WebPages.Deployment.dll</HintPath>\r\n    </Reference>\r\n    <" +
                    "Reference Include=\"System.Web.WebPages.Razor, Version=2.0.0.0, Culture=neutral, " +
                    "PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL\">\r\n      <Private>Tr" +
                    "ue</Private>\r\n      <HintPath>..\\packages\\Microsoft.AspNet.WebPages.2.0.30506.0\\" +
                    "lib\\net40\\System.Web.WebPages.Razor.dll</HintPath>\r\n    </Reference>\r\n    <Refer" +
                    "ence Include=\"WebGrease\">\r\n      <HintPath>..\\packages\\WebGrease.1.5.2\\lib\\WebGr" +
                    "ease.dll</HintPath>\r\n    </Reference>\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n  ");
            
            #line 138 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"

    foreach (var schema in this.Project.Schemas)
    {
        foreach (var table in schema.Value.Tables)
        {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 144 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format(@"Models\{0}ViewModel.cs", table.CsFullName)));
            
            #line default
            #line hidden
            this.Write("\" />\r\n    <Compile Include=\"");
            
            #line 145 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format(@"Convertors\{0}Convertor.cs", table.CsFullName)));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 146 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 151 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"

//Controllers

            
            #line default
            #line hidden
            
            #line 154 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"



            
            #line default
            #line hidden
            
            #line 157 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"

//Convertors

            
            #line default
            #line hidden
            
            #line 160 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"

//Views

            
            #line default
            #line hidden
            this.Write(@"
    <Compile Include=""Areas\Account\Models\LoginViewModel.cs"" />
    <Compile Include=""Areas\Project\Controllers\ProjectHomeController.cs"" />
    <Compile Include=""Areas\Project\Convertors\ProjectConvertor.cs"" />
    <Compile Include=""Areas\Project\Models\CreateProjectViewModel.cs"" />
    <Compile Include=""Areas\Project\ProjectAreaRegistration.cs"" />
    <Compile Include=""Controllers\HomeController.cs"" />
    <Compile Include=""Global.asax.cs"">
      <DependentUpon>Global.asax</DependentUpon>
    </Compile>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
  </ItemGroup>
  <ItemGroup>
");
            
            #line 176 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"

    if(this.Project.ReferencedProjects != null && this.Project.ReferencedProjects.Count > 0)
    {
        foreach(var project in this.Project.ReferencedProjects)
        {

            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"..\\");
            
            #line 182 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.FullName));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 182 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.FullName));
            
            #line default
            #line hidden
            this.Write(".csproj\">\r\n      <Project>{");
            
            #line 183 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid.ToString()));
            
            #line default
            #line hidden
            this.Write("}</Project>\r\n      <Name>");
            
            #line 184 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.FullName));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n");
            
            #line 186 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\View\CSharp_View_Project_Template.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n    <Content Include=\"log4net.config\" />\r\n  </Item" +
                    "Group>\r\n  <PropertyGroup>\r\n    <VisualStudioVersion Condition=\"\'$(VisualStudioVe" +
                    "rsion)\' == \'\'\">10.0</VisualStudioVersion>\r\n    <VSToolsPath Condition=\"\'$(VSTool" +
                    "sPath)\' == \'\'\">$(MSBuildExtensionsPath32)\\Microsoft\\VisualStudio\\v$(VisualStudio" +
                    "Version)</VSToolsPath>\r\n  </PropertyGroup>\r\n  <Import Project=\"$(MSBuildBinPath)" +
                    "\\Microsoft.CSharp.targets\" />\r\n  <Import Project=\"$(VSToolsPath)\\WebApplications" +
                    "\\Microsoft.WebApplication.targets\" Condition=\"\'$(VSToolsPath)\' != \'\'\" />\r\n  <Imp" +
                    "ort Project=\"$(MSBuildExtensionsPath32)\\Microsoft\\VisualStudio\\v10.0\\WebApplicat" +
                    "ions\\Microsoft.WebApplication.targets\" Condition=\"false\" />\r\n  <Target Name=\"Mvc" +
                    "BuildViews\" AfterTargets=\"AfterBuild\" Condition=\"\'$(MvcBuildViews)\'==\'true\'\">\r\n " +
                    "   <AspNetCompiler VirtualPath=\"temp\" PhysicalPath=\"$(WebProjectOutputDir)\" />\r\n" +
                    "  </Target>\r\n  <ProjectExtensions>\r\n    <VisualStudio>\r\n      <FlavorProperties " +
                    "GUID=\"{349c5851-65df-11da-9384-00065b846f21}\">\r\n        <WebProjectProperties>\r\n" +
                    "          <UseIIS>True</UseIIS>\r\n          <AutoAssignPort>True</AutoAssignPort>" +
                    "\r\n          <DevelopmentServerPort>26263</DevelopmentServerPort>\r\n          <Dev" +
                    "elopmentServerVPath>/</DevelopmentServerVPath>\r\n          <IISUrl>http://localho" +
                    "st:26263/</IISUrl>\r\n          <NTLMAuthentication>False</NTLMAuthentication>\r\n  " +
                    "        <UseCustomServer>False</UseCustomServer>\r\n          <CustomServerUrl>\r\n " +
                    "         </CustomServerUrl>\r\n          <SaveServerSettingsInUserFile>False</Save" +
                    "ServerSettingsInUserFile>\r\n        </WebProjectProperties>\r\n      </FlavorProper" +
                    "ties>\r\n    </VisualStudio>\r\n  </ProjectExtensions>\r\n  <!-- To modify your build " +
                    "process, add your task inside one of the targets below and uncomment it. \r\n     " +
                    "  Other similar extension points exist, see Microsoft.Common.targets.\r\n  <Target" +
                    " Name=\"BeforeBuild\">\r\n  </Target>\r\n  <Target Name=\"AfterBuild\">\r\n  </Target> -->" +
                    "\r\n</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class CSharp_View_Project_TemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
