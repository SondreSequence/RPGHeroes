using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Items;

namespace RPG_Heroes_Tests
{

    public class MageTest
    {
        [Fact]
        public void CreateMageTest_CreatesMage()
        {
            // Arrange
            int expectedLevel = 1;
            string expectedName = "Zondre";

            //Act
            Mage Zondre = new Mage("Zondre");

            // Assert
            Assert.All(new (object actual, object expected)[] 
            {(Zondre.Level, expectedLevel),(Zondre.Name, expectedName)}, 
            tuple => Assert.Equal(tuple.expected, tuple.actual));
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
