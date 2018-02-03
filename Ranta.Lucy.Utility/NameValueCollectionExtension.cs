using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Utility
{
    public static class NameValueCollectionExtension
    {
        public static string ToQueryString(this NameValueCollection collection)
        {
            string queryString = string.Empty;

            List<string> list = new List<string>();

            if (collection != null)
            {
                foreach (var key in collection.AllKeys)
                {
                    list.Add(string.Format("{0}={1}", key, collection[key]));
                }
            }

            queryString = string.Join("&", list);

            return queryString;
        }
    }
}
