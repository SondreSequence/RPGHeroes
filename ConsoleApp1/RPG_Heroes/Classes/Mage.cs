using ConsoleApp1.RPG_Heroes.Items;

namespace ConsoleApp1.Hero.Classes
{
    public class Mage : ConsoleApp1.RPG_Heroes.Hero
    {
        public Mage(string name) : base(name)
        {
            heroMultiplier = new int[] { 1, 1, 5 };
            LevelAttributes = new(1, 1, 8);
            DamagingAttributePos = 2;
            validWeaponTypes.AddRange(new[] { Weapon.WeaponTypes.Staffs, Weapon.WeaponTypes.Wand });
            validArmorTypes.AddRange(new[] { Armor.ArmorTypes.Cloth });
        }


    }
}
