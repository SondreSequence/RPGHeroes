using ConsoleApp1.RPG_Heroes.Items;

namespace ConsoleApp1.Hero.Classes
{
    public class Warrior : ConsoleApp1.RPG_Heroes.Hero
    {
        public Warrior(string name) : base(name)
        {
            heroMultiplier = new int[] { 3, 2, 1 };
            LevelAttributes = new(5, 2, 1);
            DamagingAttributePos = 0;
            validWeaponTypes.AddRange(new[] { Weapon.WeaponTypes.Axe, Weapon.WeaponTypes.Hammer, Weapon.WeaponTypes.Sword });
            validArmorTypes.AddRange(new[] { Armor.ArmorTypes.Mail, Armor.ArmorTypes.Plate });
        }


    }
}
