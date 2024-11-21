using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewriteRPG.Locations
{
    internal class Location
    {
        private static int _idCount = 0;
        public string Name { get; private set; }
        public int LevelZone { get; private set; }
        public int ID { get; private set; }
        public List<Location> ConnectedLocations { get; private set; }

        public Location(string name) 
        {
            Name = name;
        }
        public void AddConnection(Location location)
        {
            ConnectedLocations.Add(location);
        }

    }

}
