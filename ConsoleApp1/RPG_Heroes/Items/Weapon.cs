﻿using ConsoleApp1.Heros.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.RPG_Heroes.Items
{
    public class Weapon : Item
    {
        public enum WeaponTypes {Axe, Bow, Dagger, Hammer, Staffs, Sword, Wand}
        public WeaponTypes WeaponType;
        public double WeaponDamage;
        public Weapon(string name, int requiredlevel, double weaponDamage, WeaponTypes weaponType) : base(name, requiredlevel)
        {
            WeaponDamage = weaponDamage;
            WeaponType = weaponType;
            SlotType = Slot.Weapon;
        }
    }
}
