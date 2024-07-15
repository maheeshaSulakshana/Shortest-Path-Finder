using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathFinder
{
    internal class City
    {
        private String name;
        private List<Route> routes;
        private int visited;

        public City()
        {
            this.name = "";
            this.routes = null;
            this.visited = 0;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Route> Routes
        {
            get { return this.routes; }
            set { this.routes = value; }
        }

        public int Visited
        {
            get { return this.visited; }
            set { this.visited = value; }
        }

        public bool isfullyVisted()
        {
            if (this.routes.Count == this.visited)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int findRoute(Route route)
        {
            int index = 0;
            foreach (Route path in routes)
            {
                if (path.Source == route.Source &&
                    path.Destination == route.Destination &&
                    path.Distance == route.Distance)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public int findUnvisited()
        {
            int index = 0;
            foreach (Route route in routes)
            {
                if (route.Visited == false)
                {
                    index = routes.IndexOf(route);
                    break;
                }
            }
            return index;
        }
    }
}

