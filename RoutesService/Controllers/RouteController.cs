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
            return ""+RouteManager.GetInstance().GetNumberOfRoutes();
        }

        [HttpPost]
        public List<string> GetPoints()
        {
            return RouteManager.GetInstance().GetAllPoints();
        }

        // POST api/values
        [HttpPost]
        public void AddPoint([FromBody]string name)
        {
            
            RouteManager.GetInstance().RetrieveOrGeneratePoint(name);
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
