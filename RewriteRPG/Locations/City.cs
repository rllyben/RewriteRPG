using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RewriteRPG.Traders;

namespace RewriteRPG.Locations
{
    internal class City : Location
    {
        List<Trader> CityTrader = new List<Trader>();
        public City(string name) : base(name) { }
        public void AddTrader(Trader trader)
        {
            CityTrader.Add(trader);
        }

    }

}
