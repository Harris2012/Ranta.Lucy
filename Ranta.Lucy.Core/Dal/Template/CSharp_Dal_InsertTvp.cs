﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 14.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Ranta.Lucy.Core.Dal.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CSharp_Dal_InsertTvp : CSharp_Dal_InsertTvpBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace ");
            
            #line 6 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.FullName));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using System;\r\n    using System.Collections.Generic;\r\n    using System.D" +
                    "ata;\r\n    using System.Data.SqlClient;\r\n\r\n    public partial class ");
            
            #line 13 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.CsFullName));
            
            #line default
            #line hidden
            this.Write("_Dal\r\n    {\r\n        public List<");
            
            #line 15 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.DalEntity));
            
            #line default
            #line hidden
            this.Write("> Insert");
            
            #line 15 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.CsFullName));
            
            #line default
            #line hidden
            this.Write("s(List<");
            
            #line 15 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.DalEntity));
            
            #line default
            #line hidden
            this.Write("> entities, SqlConnection sqlConn)\r\n        {\r\n            var list = new List<");
            
            #line 17 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.DalEntity));
            
            #line default
            #line hidden
            this.Write(">();\r\n\r\n            SqlCommand sqlCmd = new SqlCommand();\r\n            sqlCmd.Con" +
                    "nection = sqlConn;\r\n            sqlCmd.CommandText = \"");
            
            #line 21 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.SP_TVP_INSERT()));
            
            #line default
            #line hidden
            this.Write("\";\r\n            sqlCmd.CommandType = CommandType.StoredProcedure;\r\n\r\n            " +
                    "#region Prepare Parameters\r\n            DataTable table = new DataTable();\r\n\r\n  " +
                    "          #region Columns\r\n            table.Columns.Add(\"Id\", typeof(int));\r\n");
            
            #line 29 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"

    foreach(var field in this.Table.Fields)
    {

            
            #line default
            #line hidden
            this.Write("            table.Columns.Add(\"");
            
            #line 33 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", typeof(");
            
            #line 33 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.PropertyType));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 34 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"            table.Columns.Add(""CreateTime"", typeof(DateTime));
            table.Columns.Add(""LastUpdateTime"", typeof(DateTime));
            #endregion

            int index=1;

            foreach (var entity in entities)
            {
                var row = table.NewRow();

                #region Rows
                row[""Id""] = index++;
");
            
            #line 49 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"

    foreach(var field in this.Table.Fields)
    {

            
            #line default
            #line hidden
            this.Write("                row[\"");
            
            #line 53 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\"] = entity.");
            
            #line 53 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 54 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"

    }

            
            #line default
            #line hidden
            this.Write("                row[\"CreateTime\"] = DateTime.Now;\r\n                row[\"LastUpdat" +
                    "eTime\"] = DateTime.Now;\r\n                #endregion\r\n\r\n                table.Row" +
                    "s.Add(row);\r\n            }\r\n\r\n            SqlParameter tvpParameter = new SqlPar" +
                    "ameter(@\"");
            
            #line 64 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.TVP_PARAM_NAME()));
            
            #line default
            #line hidden
            this.Write(@""", SqlDbType.Structured);
            tvpParameter.Value = table;
            sqlCmd.Parameters.Add(tvpParameter);
            #endregion

            var reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new ");
            
            #line 72 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.DalEntity));
            
            #line default
            #line hidden
            this.Write("();\r\n\r\n                #region Convert\r\n                item.Id = Convert.ToInt32" +
                    "(reader[\"Id\"]);\r\n");
            
            #line 76 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"

    foreach(var field in this.Table.Fields)
    {

            
            #line default
            #line hidden
            this.Write("                item.");
            
            #line 80 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 80 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.ConvertMethod));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 81 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Dal\Template\CSharp_Dal_InsertTvp.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"                item.CreateTime = Convert.ToDateTime(reader[""CreateTime""]);
                item.LastUpdateTime = Convert.ToDateTime(reader[""LastUpdateTime""]);
                #endregion

                list.Add(item);
            }

            reader.Close();

            return list;
        }
    }
}");
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
    public class CSharp_Dal_InsertTvpBase
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
