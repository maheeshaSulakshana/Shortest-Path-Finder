using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathFinder
{
    internal class MapDb
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader dr;
        String query;
        List<City> cities = new List<City>();
        List<List<String>> paths = new List<List<String>>();
        double[] distanceList = new double[10];
        int minIndex = 0;
        public MapDb()
        {
            con = new DbConnection().getConnection();
            constructMap();
        }

        public List<String> getTownNames()
        {
            con.Open();
            query = "Select name from cities";
            com = new MySqlCommand(query, con);
            dr = com.ExecuteReader();
            List<String> citylist = new List<String>();
            while (dr.Read())
            {
                citylist.Add(dr.GetString(0));
            }
            con.Close();
            return citylist;
        }

        public List<Route> getRoutes(String city)
        {
            con.Open();
            query = "Select * from routes where Source = '" + city + "' or Destination = '" + city + "'";
            com = new MySqlCommand(query, con);
            dr = com.ExecuteReader();
            List<Route> routelist = new List<Route>();
            while (dr.Read())
            {
                Route route = new Route();
                route.Source = dr.GetString(1);
                route.Destination = dr.GetString(2);
                route.Distance = dr.GetDouble(3);
                routelist.Add(route);
            }
            con.Close();
            return routelist;
        }

        public List<Route> getAllRoutes()
        {
            con.Open();
            query = "Select source, destination, distance from routes";
            com = new MySqlCommand(query, con);
            dr = com.ExecuteReader();
            List<Route> routelist = new List<Route>();
            while (dr.Read())
            {
                Route route = new Route();
                route.Source = dr.GetString(0);
                route.Destination = dr.GetString(1);
                route.Distance = dr.GetDouble(2);
                routelist.Add(route);
            }
            con.Close();
            return routelist;
        }

        public void constructMap()
        {
            List<String> towns = getTownNames();
            foreach (String town in towns)
            {
                List<Route> routes = getRoutes(town);

                City city = new City();
                city.Name = town;
                city.Routes = routes;

                cities.Add(city);
            }
        }

        public City findCity(String cityName)
        {
            City town = null;

            foreach (City city in cities)
            {
                if (city.Name == cityName)
                {
                    town = city;
                    break;
                }
            }

            return town;
        }

        public void findDestination(String source, String destination)
        {
            City sourceCity = findCity(source);
            City destinationCity = findCity(destination);
            TraverseStack cityStack = new TraverseStack();
            int i = 0;
            do
            {
                while (sourceCity.Name != destinationCity.Name)
                {
                    if (!sourceCity.isfullyVisted())
                    {
                        int index = sourceCity.findUnvisited();
                        if (sourceCity.Routes[index].Visited == false)
                        {
                            City nextCity;
                            if (sourceCity.Routes[index].Destination != sourceCity.Name)
                            {
                                nextCity = findCity(sourceCity.Routes[index].Destination);
                            }
                            else
                            {
                                nextCity = findCity(sourceCity.Routes[index].Source);
                            }
                            int temp = nextCity.findRoute(sourceCity.Routes[index]);
                            nextCity.Routes[temp].Visited = true;
                            nextCity.Visited += 1;
                            sourceCity.Routes[index].Visited = true;
                            sourceCity.Visited += 1;
                            cityStack.push(sourceCity);
                            distanceList[i] = distanceList[i] + sourceCity.Routes[index].Distance;
                            sourceCity = nextCity;
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (!cityStack.isEmpty())
                        {
                            sourceCity = cityStack.pop();
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (!cityStack.isEmpty())
                {
                    List<String> path = new List<String>();
                    foreach (City city in cityStack.getStack())
                    {
                        path.Add(city.Name);
                    }
                    paths.Add(path);
                    sourceCity = cityStack.pop();
                    i++;
                }
                else
                {
                    break;
                }
            } while (true);
        }

        public void findMinDistance()
        {
            int i = 0;
            minIndex = 0;
            double min = distanceList[i];
            i++;
            while (i < paths.Count)
            {
                if (min > distanceList[i])
                {
                    min = distanceList[i];
                    minIndex = i;
                }
                i++;
            }
        }

        public List<String> getPath()
        {
            return paths[minIndex];
        }
        public double getDistance()
        {
            return distanceList[minIndex];
        }
    }
}

