using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoutesService.Models
{
    public class Route
    {
        Point origin;
        Point destination;
        int cust;
        int time;

        public Route(Point origin, Point destination, int cust, int time)
        {
            this.origin = origin;
            this.destination = destination;
            this.cust = cust;
            this.time = time;
        }
    }


}