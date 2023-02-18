using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes.Items;
using ConsoleApp1.RPG_Heroes;

namespace RPG_Heroes_Tests
{

    /*
    If I had to choose between Mage, Warrior, Rogue, or Ranger, I would still say that Rick Astley would most likely be a Bard.
    However, if I had to choose from the given options, I would say that he might fit the Rogue class the best. Rick Astley is known for his smooth and charming personality, which are key traits of a Rogue. Rogues are also skilled in deception, stealth, and agility, which could be represented by Rick Astley's ability to surprise his listeners with unexpected twists in his songs or his ability to move gracefully on stage.
    Furthermore, Rogues often have a talent for performing tasks that require precision and finesse, such as lockpicking or pickpocketing, which could be likened to Rick Astley's precision in his singing and dancing.
    Overall, while he might not fit the traditional mold of a Rogue, Rick Astley's charm, agility, and precision make him a strong candidate for this class.
    */

    public class HeroTests
    {

        [Fact]
        public void HeroStatsWithoutEquipment_CorrectStatsWithoutEquipment()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            HeroAttributes expected = new(1, 1, 8);
            HeroAttributes actual = Zondre.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void HeroStatsWithOnePiece_CorrectStatsWithOnePieceOfEquipment()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            Armor ArmorPiece = new Armor("EnchantedArmor", 1, Armor.ArmorTypes.Cloth, Armor.Slot.Body, new HeroAttributes(10, 10, 10));
            HeroAttributes expected = new(11, 11, 18);
            HeroAttributes actual;

            //Act
            Zondre.EquipItem(ArmorPiece);
            actual = Zondre.TotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void HeroStatsWithTwoPieces_CorrectStatsWithTwoPiecesOfEquipment()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            Armor ArmorPiece = new Armor("EnchantedArmorBody", 1, Armor.ArmorTypes.Cloth, Armor.Slot.Body, new HeroAttributes(10, 10, 10));
            Armor ArmorPiece1 = new Armor("EnchantedArmorHead", 1, Armor.ArmorTypes.Cloth, Armor.Slot.Head, new HeroAttributes(10, 10, 10));
            HeroAttributes expected = new(21, 21, 28);
            HeroAttributes actual;

            //Act
            Zondre.EquipItem(ArmorPiece);
            Zondre.EquipItem(ArmorPiece1);
            actual = Zondre.TotalAttributes();

            //Assert
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void HeroStatsWithReplacedArmor_CorrectStatsWithReplacedArmorInSameSlot()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            Armor ArmorPiece = new Armor("EnchantedArmorBody", 1, Armor.ArmorTypes.Cloth, Armor.Slot.Body, new HeroAttributes(10, 10, 10));
            Armor ArmorPiece1 = new Armor("EpicEnchantedBody", 1, Armor.ArmorTypes.Cloth, Armor.Slot.Body, new HeroAttributes(14, 14, 14));
            HeroAttributes expected = new(15, 15, 22);
            HeroAttributes actual;

            //Act
            Zondre.EquipItem(ArmorPiece);
            Zondre.EquipItem(ArmorPiece1);
            actual = Zondre.TotalAttributes();

            // Assert
            Assert.Equivalent(expected, actual);
        }

        [Fact]
        public void HeroDamageWithNoWeapon_CorrectDamageWithNoWeapon()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            double expected = 1.0;
            double actual = (int)Zondre.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HeroDamageWithWeapon_CorrectDamageWithWeapon()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            Weapon Weapon = new Weapon("Staff", 1, 1, Weapon.WeaponTypes.Staffs);
            double expected = 1.08;
            double actual;

            //Act
            Zondre.EquipItem(Weapon);
            actual = Zondre.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HeroDamageWithReplacedWeapon_CorrectDamageWithReplacedWeapon()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            Weapon Weapon = new Weapon("Staff", 1, 1, Weapon.WeaponTypes.Staffs);
            Weapon Weapon1 = new Weapon("Staff", 1, 2, Weapon.WeaponTypes.Staffs);
            double expected = 2.16;
            double actual;

            // Act
            Zondre.EquipItem(Weapon);
            Zondre.EquipItem(Weapon1);
            actual = Zondre.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HeroDamageWithWeaponAndArmor_CorrectDamageWithWeaponAndArmor()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            Weapon Weapon = new Weapon("Staff", 1, 2, Weapon.WeaponTypes.Staffs);
            Armor Armor = new Armor("EnchantedCloth", 1, Armor.ArmorTypes.Cloth, ConsoleApp1.Heros.Items.Item.Slot.Body, new HeroAttributes(2, 2, 2));
            double expected = 2.20;
            double actual;

            //Act
            Zondre.EquipItem(Weapon);
            Zondre.EquipItem(Armor);
            actual = Zondre.Damage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HeroDisplayTest_CorrectDisplay()
        {
            // Arrange
            Hero Zondre = new Mage("Rick Astely");
            string expected = 
                "\nName " + Zondre.Name 
                + "\r\nLevel " + Zondre.Level 
                + "\n\r\nEquipped Items\r\n\n" 
                + "Base Attributes: \nStrength: " + Zondre.LevelAttributes.Strength + " Dexterity: " + Zondre.LevelAttributes.Dexterity + " Intelligence: " + Zondre.LevelAttributes.Intelligence 
                + "\r\n\nTotal Attributes:\nStrength: " 
                + Zondre.TotalAttributes().Strength + " Dexterity: " + Zondre.LevelAttributes.Dexterity + " Intelligence: " + Zondre.LevelAttributes.Intelligence 
                + "\r\n\nRick Astely's total damage output: " 
                + Zondre.Damage()+"\r\n";

            //Act
            string actual = Zondre.Display();

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
