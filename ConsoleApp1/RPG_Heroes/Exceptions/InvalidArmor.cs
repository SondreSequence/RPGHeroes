using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.RPG_Heroes.Exceptions
{
    internal class InvalidArmor: Exception
    {

        public InvalidArmor()
        {
        }

        public InvalidArmor(string message)
            : base(message)
        {
        }
        public override string Message => "Invalid Armor Breh";

    }

}

