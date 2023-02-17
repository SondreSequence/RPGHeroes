using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.RPG_Heroes.Exceptions
{
    internal class InvalidWeapon: Exception
    {

        public InvalidWeapon()
        {
        }

        public InvalidWeapon(string message)
            : base(message)
        {
        }
        public override string Message => "Invalid Weapon Breh";

    }
}
