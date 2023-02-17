using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_Tests
{
    public class WarriorTests
    {
        [Fact]
        public void CreateWarriorTest_CreatesWarrior()
        {
            // Arrange
            Warrior Zondre = new Warrior("Zondre");

            // Assert
            Assert.NotNull(Zondre);
            Assert.Equal("Zondre", Zondre.Name);
            Assert.Equal(1, Zondre.Level);
        }

        [Fact]
        public void LevelUpTest_WarriorLevelUp()
        {
            // Arrange
            Warrior Zondre = new Warrior("Zondre");

            //Act
            Zondre.LevelUp();

            // Assert
            Assert.Equal(2, Zondre.Level);
            
            Assert.Equal(new(8, 4, 2), Zondre.LevelAttributes);
        }

        [Fact]
        public void HeroAttributesTest_AddStats()
        {
            // Arrange
            Warrior Zondre = new Warrior("Zondre");

            // Assert
            Assert.Equal(new(5, 2, 1), Zondre.LevelAttributes);
        }
    }
}
