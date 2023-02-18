using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Items;

namespace RPG_Heroes_Tests
{

    public class WarriorTest
    {
        public class WarriorTests
        {
            [Fact]
            public void CreateWarriorTest_CreatesWarriorWithLevelOne()
            {
                // Arrange
                int expectedLevel = 1;

                //Act
                Warrior Zondre = new Warrior("Zondre");

                // Assert
                Assert.Equal(expectedLevel, Zondre.Level);
            }

            [Fact]
            public void CreateWarriorTest_CreatesWarriorWithNameZondre()
            {
                // Arrange
                string expectedName = "Zondre";

                //Act
                Warrior Zondre = new Warrior("Zondre");

                // Assert
                Assert.Equal(expectedName, Zondre.Name);
            }
        }



        [Fact]
        public void LevelUpTest_WarriorLevelUp()
        {
            // Arrange
            Warrior Zondre = new Warrior("Zondre");
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
            Warrior Zondre = new Warrior("Zondre");
            HeroAttributes expected = new(8, 4, 2);
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
            Warrior Zondre = new Warrior("Zondre");
            HeroAttributes expected = new(5, 2, 1);
            HeroAttributes actual = Zondre.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }

    }
}
