using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Heros.Items
{
    public abstract class Item
    {
        public string Name;
        public int RequiredLevel;
        public enum Slot
        {
            Weapon,
            Head,
            Body,
            Legs
        }
        public Slot SlotType;

        protected Item(string name, int requiredlevel) {
            Name = name;
            RequiredLevel = requiredlevel;
            }

    }
}
