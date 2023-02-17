using ConsoleApp1.RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroTests
{
    internal class WarriorTests
    {
        [TestMethod]
        public void CreateWarriorTest_CreatesWarrior()
        {
            // Arrange
            Warrior Zondre = new Warrior("Zondre");

            // Assert
            Assert.IsNotNull(Zondre);
            Assert.AreEqual("Zondre", Zondre.Name);
            Assert.AreEqual(1, Zondre.Level);
        }

        [TestMethod]
        public void LevelUpTest_WarriorLevelsUp()
        {
            // Arrange
            Warrior Zondre = new Warrior("Zondre");

            //Act
            Zondre.LevelUp();

            // Assert
            Assert.AreEqual(2, Zondre.Level);
            Assert.AreEqual(new HeroAttributes(8, 4, 2), Zondre.LevelAttributes);
        }

        [TestMethod]
        public void HeroAttributesTest_AddStats()
        {
            // Arrange
            Warrior Zondre = new Warrior("Zondre");

            // Assert
            Assert.AreEqual(new HeroAttributes(5, 2, 1), Zondre.LevelAttributes);
        }
    }
}
