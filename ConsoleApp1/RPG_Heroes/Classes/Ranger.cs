using ConsoleApp1.RPG_Heroes.Items;

namespace ConsoleApp1.RPG_Heroes.Classes
{
    public class Ranger : ConsoleApp1.RPG_Heroes.Hero
    {
        public Ranger(string name) : base(name)
        {
            heroMultiplier = new int[] { 1, 5, 1 };
            LevelAttributes = new(1, 7, 1);
            DamagingAttributePos = 1;
            validWeaponTypes.AddRange(new[] { Weapon.WeaponTypes.Bow});
            validArmorTypes.AddRange(new[] { Armor.ArmorTypes.Mail, Armor.ArmorTypes.Leather});
        }
    }
}
