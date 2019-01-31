using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RunGo.Server.Controllers
{
    [RoutePrefix("api/v1/value")]
    public class ValuesController : BaseApiController
    {
        [HttpGet]
        [Route("do")]
        public IEnumerable<string> DoSomething()
        {
            var master = new MasterDbContext();
            var result = master.FetchAll<INFO_FireEquip>("INFO_FireEquip");
            return new string[] { "value1", "value2" };
        }

    }

    public partial class INFO_FireEquip
    {
        public string RowID { get; set; }
        public Nullable<System.DateTime> OperationDate { get; set; }
        public string GraphyID { get; set; }
        public string FloorNo { get; set; }
        public string EquipCode { get; set; }
        public string EquipName { get; set; }
        public string SubType { get; set; }
        public string MainType { get; set; }
        public string Point2D { get; set; }
        public string Point3D { get; set; }
        public string Status { get; set; }
        public string ElementID { get; set; }
        public string CameraID { get; set; }
        public string Remark { get; set; }
    }
}
