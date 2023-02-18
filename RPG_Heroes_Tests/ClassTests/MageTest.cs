using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Items;

namespace RPG_Heroes_Tests
{

    public class MageTest
    {
        public class MageTests
        {
            [Fact]
            public void CreateMageTest_CreatesMageWithLevelOne()
            {
                // Arrange
                int expectedLevel = 1;

                //Act
                Mage Zondre = new Mage("Zondre");

                // Assert
                Assert.Equal(expectedLevel, Zondre.Level);
            }

            [Fact]
            public void CreateMageTest_CreatesMageWithNameZondre()
            {
                // Arrange
                string expectedName = "Zondre";

                //Act
                Mage Zondre = new Mage("Zondre");

                // Assert
                Assert.Equal(expectedName, Zondre.Name);
            }
        }



        [Fact]
        public void LevelUpTest_MageLevelUp()
        {
            // Arrange
            Mage Zondre = new Mage("Zondre");
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
            Mage Zondre = new Mage("Zondre");
            HeroAttributes expected = new(1, 1, 5);
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
            Mage Zondre = new Mage("Zondre");
            HeroAttributes expected = new(1, 1, 8);
            HeroAttributes actual = Zondre.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }

    }
}
