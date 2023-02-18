using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Classes;
using ConsoleApp1.RPG_Heroes.Items;

namespace RPG_Heroes_Tests
{

    public class RogueTest
    {
        public class RogueTests
        {
            [Fact]
            public void CreateRogueTest_CreatesRogueWithLevelOne()
            {
                // Arrange
                int expectedLevel = 1;

                //Act
                Rogue Zondre = new Rogue("Zondre");

                // Assert
                Assert.Equal(expectedLevel, Zondre.Level);
            }

            [Fact]
            public void CreateRogueTest_CreatesRogueWithNameZondre()
            {
                // Arrange
                string expectedName = "Zondre";

                //Act
                Rogue Zondre = new Rogue("Zondre");

                // Assert
                Assert.Equal(expectedName, Zondre.Name);
            }
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
