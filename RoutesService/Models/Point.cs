using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoutesService.Models
{
    public class Point
    {
        private string name;

        public Point(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

    }
}