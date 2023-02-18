using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Classes;
using ConsoleApp1.RPG_Heroes.Items;

namespace RPG_Heroes_Tests
{

    public class RangerTest
    {
        public class RangerTests
        {
            [Fact]
            public void CreateRangerTest_CreatesRangerWithLevelOne()
            {
                // Arrange
                int expectedLevel = 1;

                //Act
                Ranger Zondre = new Ranger("Zondre");

                // Assert
                Assert.Equal(expectedLevel, Zondre.Level);
            }

            [Fact]
            public void CreateRangerTest_CreatesRangerWithNameZondre()
            {
                // Arrange
                string expectedName = "Zondre";

                //Act
                Ranger Zondre = new Ranger("Zondre");

                // Assert
                Assert.Equal(expectedName, Zondre.Name);
            }
        }



        [Fact]
        public void LevelUpTest_RangerLevelUp()
        {
            // Arrange
            Ranger Zondre = new Ranger("Zondre");
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
            Ranger Zondre = new Ranger("Zondre");
            HeroAttributes expected = new(1, 5, 1);
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
            Ranger Zondre = new Ranger("Zondre");
            HeroAttributes expected = new(1, 7, 1);
            HeroAttributes actual = Zondre.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }

    }
}
