using ConsoleApp1.Heros.Items;
using ConsoleApp1.RPG_Heroes.Exceptions;
using ConsoleApp1.RPG_Heroes.Items;
using System.Text;

namespace ConsoleApp1.RPG_Heroes
{
    public abstract class Hero
    {
        public string Name;
        public int Level = 1;
        public HeroAttributes LevelAttributes = new HeroAttributes(0,0,0);
        public Dictionary<Item.Slot, Item?> equipment = new Dictionary<Item.Slot, Item?>();
        public List<Weapon.WeaponTypes> validWeaponTypes = new List<Weapon.WeaponTypes>();
        public List<Armor.ArmorTypes> validArmorTypes = new List<Armor.ArmorTypes>();

        /*I could put these in each subclass, but we should do as little as possible to make a new subclass so I put them here
          to then populate them in each subclass ergo saving having to make a new heromultiplier var in each hero class for example.
        
        I also don't have to make a switch case on hero types in any method this way.
        */
        protected int[] heroMultiplier = new int[10];
        protected int DamagingAttributePos;

        public Hero(string name)
        {
            Name = name;
            equipment.Add(Item.Slot.Weapon, null);
            equipment.Add(Item.Slot.Head, null);
            equipment.Add(Item.Slot.Legs, null);
            equipment.Add(Item.Slot.Body, null);
        }

        //I make this return a string purley for testing purposes atm.
        public virtual string Display()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"\nName {Name}");
            output.AppendLine($"Level {Level}\n");

            if (equipment.Values == null) { output.AppendLine("No equipped items.");}
            else
            {
                output.AppendLine("Equipped Items");
                foreach (KeyValuePair<Item.Slot, Item> item in equipment)
                {
                    if (item.Value != null)
                        output.AppendLine(item.Key + ": " + item.Value.Name);
                }
            }

            output.AppendLine($"\nBase Attributes: \nStrength: {LevelAttributes.Strength} Dexterity: {LevelAttributes.Dexterity} Intelligence: {LevelAttributes.Intelligence}");
            HeroAttributes totalAttr = TotalAttributes();
            output.AppendLine($"\nTotal Attributes:\nStrength: {totalAttr.Strength} Dexterity: {totalAttr.Dexterity} Intelligence: {totalAttr.Intelligence}");
            output.AppendLine($"\n{Name}'s total damage output: {Damage()}");

            Console.WriteLine(output);
            return output.ToString();
        }

        /*I use a the Values Array in HeroAttributes so I can get the realtime data from TotalAttributes after the hero equips
         an item.

        Since Strength, Dexterity and Intelligence are always in positions 0,1 and 2 
        I just populate DamageAttributePos in each specific class with their unique position of that stat 
        */
        public virtual double Damage()
        {
            double WeaponDamage = 1;
            double DamageAttribute = TotalAttributes().Values[DamagingAttributePos];

            if (equipment[Item.Slot.Weapon] != null)
            {
                Weapon weapon = (Weapon)equipment[Item.Slot.Weapon];
                WeaponDamage = weapon.WeaponDamage;
            }

            double finalDamage = WeaponDamage * (1 + (DamageAttribute / 100));
            return finalDamage;
        }

        /*I do not need to override or overload this method due to this not needing to be changed in any of the hero classes
        The only relevant thing I can see to be changed in LevelUp would probably be a message,
        but then we could make a LevelUpMessage var which could then be populated in each class*/
        public void LevelUp()
        {
            Level += 1;
            LevelAttributes.IncreaseStats(heroMultiplier[0], heroMultiplier[1], heroMultiplier[2]);

        }

        public void EquipItem(Item item)
        {
            if (item is Armor)
            {
                Armor armor = (Armor)item;
                if (armor.RequiredLevel > Level)
                    throw new InvalidLevel();
                if (!validArmorTypes.Contains(armor.ArmorType))
                {
                    throw new InvalidArmor();
                }
            }
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                if (weapon.RequiredLevel > Level)
                    throw new InvalidLevel();
                if (!validWeaponTypes.Contains(weapon.WeaponType))
                {
                    throw new InvalidWeapon();
                }
            }

            /*I just remove the item before it equips so that reequipping goes smoothly
             this also works from at creation because we fill equipment with null values*/
            equipment.Remove(item.SlotType);
            equipment.Add(item.SlotType, item);
        }

        public HeroAttributes TotalAttributes()
        {
            double strength = 0;
            double dexterity = 0;
            double intelligence = 0;

            foreach (Item item in equipment.Values)
            {
                if (item is Armor)
                {
                    Armor armor = (Armor)item;
                    strength += armor.ArmorAttributes.Strength;
                    dexterity += armor.ArmorAttributes.Dexterity;
                    intelligence += armor.ArmorAttributes.Intelligence;
                }
            }

            strength += LevelAttributes.Strength;
            dexterity += LevelAttributes.Dexterity;
            intelligence += LevelAttributes.Intelligence;
            HeroAttributes TotalAttr = new(strength, dexterity, intelligence);

            return TotalAttr;
        }
    }
}
