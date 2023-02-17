using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_Tests.ClassTests
{
    public class RogueTest
    {
        [Fact]
        public void CreateRogueTest_CreatesRogue()
        {
            // Arrange
            Rogue Zondre = new Rogue("Zondre");
            int expectedLevel = 1;
            string expectedName = "Zondre";

            // Assert
            Assert.All(new (object actual, object expected)[]
            {(Zondre.Level, expectedLevel),(Zondre.Name, expectedName)},
            tuple => Assert.Equal(tuple.expected, tuple.actual));
        }

        [Fact]
        public void LevelUpTest_RogueLevelUp()
        {
            // Arrange
            Rogue Zondre = new Rogue("Zondre");
            int actual = 2;
            int expected;

            //Act
            Zondre.LevelUp();
            expected = Zondre.Level;

            // Assert
            Assert.Equal(actual, expected);
        }

        public void HeroAttributesTest_IncreaseStats()
        {


            // Arrange
            Rogue Zondre = new Rogue("Zondre");
            HeroAttributes expected = new(1, 4, 1);
            HeroAttributes actual = Zondre.LevelAttributes;

            //Act
            Zondre.LevelUp();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HeroAttributesTest_AddStats()
        {
            // Arrange
            Rogue Zondre = new Rogue("Zondre");
            HeroAttributes expected = new(2, 6, 1);
            HeroAttributes actual = Zondre.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
    }
}
