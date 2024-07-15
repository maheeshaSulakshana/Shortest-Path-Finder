using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathFinder
{
    internal class Route
    {
        private String source;
        private String destination;
        private double distance;
        private bool visited;

        public Route()
        {
            this.source = "";
            this.destination = "";
            this.distance = 0.0;
            this.visited = false;
        }

        public String Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        public String Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        public double Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public bool Visited
        {
            get { return this.visited; }
            set { this.visited = value; }
        }
    }
}

