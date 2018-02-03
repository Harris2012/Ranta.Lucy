using Ranta.Lucy.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ranta.Lucy.Api.Controllers
{
    public class DatabaseController : ApiController
    {
        public List<Database> DatabaseList()
        {
            List<Database> returnValue = new List<Database>();

            for (int i = 0; i < 5; i++)
            {
                returnValue.Add(new Database { Id = i, Name = "db" + i });
            }

            return returnValue;
        }

        public int TableList(string tableName)
        {
            return 1;
        }
    }
}
