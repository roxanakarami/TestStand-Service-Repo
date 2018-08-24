using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net;
using System.Net.Http;

namespace TestStandService
{
   public class ValuesController : ApiController
    {
        public String GetString(Int32 id)
        {
            return "This is string returned through windows service";
        }

    }
}
