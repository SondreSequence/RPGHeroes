using ConsoleApp1.Heros.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.RPG_Heroes.Items.Weapon;

namespace ConsoleApp1.RPG_Heroes.Items
{
    public class Armor : Item
    {
        public enum ArmorTypes {Cloth,Leather,Mail,Plate}
        public ArmorTypes ArmorType;
        public HeroAttributes ArmorAttributes;


        public Armor(string name, int requiredlevel, ArmorTypes Type, Slot slotType, HeroAttributes ArmorAtt) : base(name, requiredlevel)
        {   
            ArmorType = Type;
            SlotType = slotType;
            ArmorAttributes = ArmorAtt;
        }
    }
}
