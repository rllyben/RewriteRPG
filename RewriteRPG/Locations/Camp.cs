using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RewriteRPG.Traders;

namespace RewriteRPG.Locations
{
    internal class Camp : FieldArea
    {
        public List<Trader> CampTraders { get; private set; } = new List<Trader>();
        public Camp(string name) : base(name)
        {

        }
        public void AddTrader(Trader trader)
        {
            CampTraders.Add(trader);
        }

    }

}
