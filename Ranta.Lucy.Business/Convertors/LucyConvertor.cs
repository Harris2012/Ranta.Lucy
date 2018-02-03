using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design = Ranta.Lucy.Business.Models.Design;
using Core = Ranta.Lucy.Core;

namespace Ranta.Lucy.Business.Convertors
{
    public static class LucyConvertor
    {
        public static Core.Table ToCoreTable(Design.Table designTable)
        {
            var coreTable = new Core.Table();

            coreTable.Name = designTable.Name;
            coreTable.Fields = new List<Core.Field>();
            if (designTable.Fields != null && designTable.Fields.Count > 0)
            {
                foreach (var designField in designTable.Fields.Values)
                {
                    var coreField = new Core.Field();

                    coreField.Name = designField.Name;
                    coreField.FieldType = (Core.FieldType)designField.FieldType;
                    coreField.FieldSize = designField.FieldSize;
                    coreField.Nullable = designField.Nullable;
                    coreField.Multiple = designField.Multiple;

                    coreTable.Fields.Add(coreField);
                }
            }

            return coreTable;
        }

        public static Core.CSharpDalProject ToCoreDalProject(string name)
        {
            var coreProject = new Core.CSharpDalProject();

            coreProject.Name = name;

            return coreProject;
        }
    }
}
