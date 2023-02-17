using ConsoleApp1.RPG_Heroes.Items;

namespace ConsoleApp1.RPG_Heroes.Classes
{
    public class Rogue : ConsoleApp1.RPG_Heroes.Hero
    {
        public Rogue(string name) : base(name)
        {
            heroMultiplier = new int[] { 1, 4, 1 };
            LevelAttributes = new(2, 6, 1);
            DamagingAttributePos = 1;
            validWeaponTypes.AddRange(new[] { Weapon.WeaponTypes.Dagger, Weapon.WeaponTypes.Sword });
            validArmorTypes.AddRange(new[] { Armor.ArmorTypes.Mail, Armor.ArmorTypes.Leather });
        }
    }
}
