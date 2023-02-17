using ConsoleApp1.RPG_Heroes.Items;
using ConsoleApp1.Heros.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.Hero.Classes;
using Newtonsoft.Json.Linq;

namespace RPG_Heroes_Tests.ArmorTests
{
    public class ArmorTests
    {
        [Fact]
        public void CreateArmorTest_CreatesArmor()
        {
            // Arrange
            Armor actualArmor = new Armor("EnchantedPlate", 1, Armor.ArmorTypes.Plate, Armor.Slot.Body, new(1, 10, 1));

            // Assert
            Assert.All(new (object actual, object expected)[]
            {(actualArmor.Name, "EnchantedPlate"),
             (actualArmor.RequiredLevel, 1),
             (actualArmor.ArmorAttributes, new HeroAttributes(1, 10, 1)),
             (actualArmor.ArmorType, Armor.ArmorTypes.Plate),
             (actualArmor.SlotType, Item.Slot.Body)
            },
            tuple => Assert.Equivalent(tuple.expected, tuple.actual));
        }

        //I'm only testing equip once due to it not being said in the assignment that it should be tested in all subclasses
        [Fact]
        public void EquipArmorTest_EquipsArmor()
        {
            // Arrange
            Hero hero = new Warrior("Zondre");
            Armor armor = new Armor("EnchantedPlate", 1, Armor.ArmorTypes.Plate, Armor.Slot.Body, new HeroAttributes(1, 10, 1));

            // Act
            hero.EquipItem(armor);
            Armor expectedArmor = (Armor)hero.equipment[Armor.Slot.Body];

            // Assert
            Assert.Equivalent(armor, expectedArmor);
        }
    }
}
