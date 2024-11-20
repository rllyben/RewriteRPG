using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RewriteRPG.Exceptions
{
    internal class NonOfThatItemException : Exception
    {
        public NonOfThatItemException(string msg) : base(msg) { }
        public NonOfThatItemException(Exception e) :
            base("Does not have that Item", e) { }

    }
    internal class LevelToLowException : Exception
    {
        public LevelToLowException(string msg) : base(msg) { }
        public LevelToLowException(Exception e) :
            base("Character level is to low to use that item!") { }
    }
    internal class NonEquipableItemException : Exception
    {
        public NonEquipableItemException(string msg) : base(msg) { }
        public NonEquipableItemException(Exception e) :
            base("Item is not Equipable", e)
        { }
    }

}
