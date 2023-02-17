
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ConsoleApp1.RPG_Heroes.Items.Weapon;

namespace HeroTests
{
    [TestClass]
    public class HeroTests
    {

        [TestMethod]
        public void CreateWeaponTest_CreatesWeapon()
        {
            // Arrange
            Weapon weapon = new Weapon("Sword", 1, 15, Weapon.WeaponTypes.Sword);

            // Assert
            Assert.IsNotNull(weapon);
            Assert.AreEqual("Sword", weapon.Name);
            Assert.AreEqual(1, weapon.RequiredLevel);
            Assert.AreEqual(15, weapon.WeaponDamage);
            Assert.AreEqual(Weapon.WeaponTypes.Sword, weapon.WeaponType);
        }

        [TestMethod]
        public void LevelUpWarriorTest_IncrementsLevelAndAttributes()
{
    // Arrange
    Hero warrior = new Warrior("Zondre");
    int expectedLevel = 2;
    int expectedStrength = 8;
    int expectedDexterity = 4;
    int expectedIntelligence = 2;

    // Act
    warrior.LevelUp();

    // Assert
    Assert.AreEqual(expectedLevel, warrior.Level);
    Assert.AreEqual(expectedStrength, warrior.LevelAttributes.Strength);
    Assert.AreEqual(expectedDexterity, warrior.LevelAttributes.Dexterity);
    Assert.AreEqual(expectedIntelligence, warrior.LevelAttributes.Intelligence);
}
    }


}