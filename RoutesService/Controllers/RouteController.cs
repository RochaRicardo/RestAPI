using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutesService.Controllers
{
    public class RouteController : ApiController
    {

        [HttpGet]
        public string NumberOfRoutes()
        {
            return ""+RouteManager.RouGetInstance().GetNumberOfRoutes();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
