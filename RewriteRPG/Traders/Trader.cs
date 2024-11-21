using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewriteRPG.Traders
{
    internal class Trader
    {
        public string Name { get; private set; }
        public Trader(string name)
        {
            Name = name;
        }

    }

}
