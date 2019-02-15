using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Abp.WebApi.Controllers;

namespace RunGo.Server.Controllers
{
    [RoutePrefix("api/v1/value")]
    public class ValuesController : AbpApiController
    {
        [HttpGet]
        [Route("do")]
        public IEnumerable<string> DoSomething()
        {
            return new string[] { "value1", "value2" };
        }

    }

}
