using RoutesService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RoutesService.Controllers
{
    public class RouteManager
    {
        List<Route> routes;
        List<Point> points;

        private static RouteManager instance;

        string res;

        private RouteManager()
        {
            routes = new List<Route>();

        }

        public static RouteManager RouGetInstance()
        {
            if (instance == null)
                instance = new RouteManager();
            return instance;
        }



        public List<Route> GetAllRoutes()
        {
            return this.routes;
        }

        public int GetNumberOfRoutes()
        {
            return routes.Count;
        }




        /// <summary>
        /// Add a new route to the list of routes
        /// </summary>
        /// <param name="originName">Name of the origin point</param>
        /// <param name="destinationName">Name of the destination point</param>
        /// <param name="cust">Cust of the route</param>
        /// <param name="time">Time of the route</param>
        public void AddRoute(string originName, string destinationName, int cust, int time)
        {
            Point origin = RetrieveOrGeneratePoint(originName);
            Point destination = RetrieveOrGeneratePoint(destinationName);

            Route newRoute = new Route(origin, destination, cust, time);
            routes.Add(newRoute);

        }

        /// <summary>
        /// Check if a point with the given name exists
        /// </summary>
        /// <param name="name">name of the point</param>
        /// <returns>The point if it eists or null if the point does not exist</returns>
        public Point PointExists(string name)
        {
            foreach(Point p in points){
                if (p.GetName() == name)
                    return p;
            }
            return null;
        }

        /// <summary>
        /// Create a point it the given name
        /// </summary>
        /// <param name="name">The name of the point</param>
        /// <returns>Returns the point created</returns>
        public Point CreatePoint(string name)
        {
            Point newPoint = new Point(name);
            this.points.Add(newPoint);
            return newPoint;
        }

        /// <summary>
        /// If the point exist retrieves it, if dont, it creates the point and retrieve the point created
        /// </summary>
        /// <param name="name">The name of the point desired</param>
        /// <returns>the point with the given name</returns>
        public Point RetrieveOrGeneratePoint(string name)
        {
            Point p = PointExists(name);
            if (p == null)
                p = CreatePoint(name);
            return p;
        }
    }
}