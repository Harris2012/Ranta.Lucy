using Ranta.Lucy.Business.Models.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace Ranta.Lucy.Business.Validators
{
    public class LucyDesignDataValidator
    {
        public List<string> Validation(string data)
        {
            List<string> validateResult = new List<string>();

            if (string.IsNullOrEmpty(data))
            {
                validateResult.Add("Data cannot be null or empty");
            }
            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                var schemas = serializer.Deserialize<Dictionary<string, Schema>>(data);

                if (schemas == null)
                {
                    validateResult.Add("Deserialize data failed.");
                }
                else
                {
                    int index = 1;

                    foreach (var schema in schemas)
                    {
                        ValidateSchema(schema, ref validateResult, ref index);
                    }
                }
            }

            return validateResult;
        }

        private void ValidateSchema(KeyValuePair<string, Schema> schema, ref List<string> validateResult, ref int index)
        {
            if (string.IsNullOrEmpty(schema.Key))
            {
                validateResult.Add(string.Format("{0}. Schema Key cannot be string.Empty.", index++));
            }
            if (schema.Value == null)
            {
                validateResult.Add(string.Format("{0}. Schema cannot be null.", index++));
            }
            else
            {
                if (schema.Value.Tables == null || schema.Value.Tables.Count == 0)
                {
                    validateResult.Add(string.Format("{0}. There should be tables in schema", index++));
                }
                else
                {
                    foreach (var table in schema.Value.Tables)
                    {
                        ValidateTable(table, ref validateResult, ref index);
                    }
                }
            }
        }

        private void ValidateTable(KeyValuePair<string, Table> table, ref List<string> validateResult, ref int index)
        {
            if (string.IsNullOrEmpty(table.Key))
            {
                validateResult.Add(string.Format("{0}. Table Key cannot be string.Empty.", index++));
            }
            if (table.Value == null)
            {
                validateResult.Add(string.Format("{0}. Table cannot be null.", index++));
            }
            else
            {
                if (table.Value.Fields == null || table.Value.Fields.Count == 0)
                {
                    validateResult.Add(string.Format("{0}. There should be fields in table", index++));
                }
                else
                {
                    foreach (var field in table.Value.Fields)
                    {
                        ValidateFeild(field, ref validateResult, ref index);
                    }
                }
            }
        }

        private void ValidateFeild(KeyValuePair<string, Field> field, ref List<string> validateResult, ref int index)
        {
            if (string.IsNullOrEmpty(field.Key))
            {
                validateResult.Add(string.Format("{0}. Field Key cannot be string.Empty.", index++));
            }
            if (field.Value == null)
            {
                validateResult.Add(string.Format("{0}. Field cannot be null.", index++));
            }
            else
            {
                //Check field
            }
        }
    }
}
