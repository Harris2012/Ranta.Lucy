﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 14.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Ranta.Lucy.Core.Template.Business
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CSharp_Business_Convertor : CSharp_Business_ConvertorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace ");
            
            #line 6 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.FullName));
            
            #line default
            #line hidden
            this.Write(".Convertors\r\n{\r\n    using System;\r\n    using System.Collections.Generic;\r\n    usi" +
                    "ng ");
            
            #line 10 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.Name));
            
            #line default
            #line hidden
            this.Write(".Dal;\r\n    using ");
            
            #line 11 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Project.FullName));
            
            #line default
            #line hidden
            this.Write(".Models;\r\n\r\n    public class ");
            
            #line 13 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.CsFullName));
            
            #line default
            #line hidden
            this.Write("Convertor\r\n    {\r\n        public ");
            
            #line 15 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.DalEntity));
            
            #line default
            #line hidden
            this.Write(" ToEntity(");
            
            #line 15 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.BusinessModel));
            
            #line default
            #line hidden
            this.Write(" model)\r\n        {\r\n            var entity = new ");
            
            #line 17 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.DalEntity));
            
            #line default
            #line hidden
            this.Write("();\r\n\r\n            #region Properties\r\n            entity.Id = model.Id;\r\n");
            
            #line 21 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"

    foreach(var field in this.Table.Fields)
    {
        if(field.Multiple)
        {

            
            #line default
            #line hidden
            this.Write("            if(model.");
            
            #line 27 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(" != null && model.");
            
            #line 27 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(".Count > 0)\r\n            {\r\n                foreach (var i in model.");
            
            #line 29 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(")\r\n                {\r\n                    entity.");
            
            #line 31 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(" |= (int)Math.Pow(2, i - 1);\r\n                }\r\n            }\r\n");
            
            #line 34 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("            entity.");
            
            #line 39 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(" = model.");
            
            #line 39 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 40 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("            entity.CreateTime = model.CreateTime;\r\n            entity.LastUpdateT" +
                    "ime = model.LastUpdateTime;\r\n            #endregion\r\n\r\n            return entity" +
                    ";\r\n        }\r\n\r\n        public ");
            
            #line 51 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.BusinessModel));
            
            #line default
            #line hidden
            this.Write(" ToModel(");
            
            #line 51 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.DalEntity));
            
            #line default
            #line hidden
            this.Write(" entity)\r\n        {\r\n            var model = new ");
            
            #line 53 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Table.BusinessModel));
            
            #line default
            #line hidden
            this.Write("();\r\n\r\n            double max = 0;\r\n\r\n            #region Properties\r\n           " +
                    " model.Id = entity.Id;\r\n");
            
            #line 59 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"

    foreach(var field in this.Table.Fields)
    {
        if(field.Multiple)
        {

            
            #line default
            #line hidden
            this.Write("            List<int> list = new List<int>();\r\n            max = Math.Log(entity." +
                    "");
            
            #line 66 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(", 2) + 2;\r\n            for (int i = 1; i < max; i++)\r\n            {\r\n            " +
                    "    if ((entity.");
            
            #line 69 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(" & (int)Math.Pow(2, i - 1)) > 0)\r\n                {\r\n                    list.Add" +
                    "(i);\r\n                }\r\n            }\r\n");
            
            #line 74 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("            model.");
            
            #line 79 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(" = entity.");
            
            #line 79 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 80 "D:\GitblitWorkspace\ranta-app\Lucy\Ranta.Lucy.Core\Template\Business\CSharp_Business_Convertor.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("            model.CreateTime = entity.CreateTime;\r\n            model.LastUpdateTi" +
                    "me = entity.LastUpdateTime;\r\n            #endregion\r\n\r\n            return model;" +
                    "\r\n        }\r\n    }\r\n}");
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
    public class CSharp_Business_ConvertorBase
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
