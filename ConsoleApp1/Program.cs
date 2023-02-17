using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Items;

namespace ConsoleApp1
{
    internal class Program
    {

        static Mage Zelen = new Mage("Zelen");
        static void Main(string[] args)
        {
            Warrior Zondre = new Warrior("Rick Astely");

            string expected = "Name " + Zondre.Name + "\r\nLevel " + Zondre.Level + "\r\n\r\nEquipped Items\r\n\r\nBase Attributes:\r\nStrength: " + Zondre.LevelAttributes.Strength + " Dexterity: " + Zondre.LevelAttributes.Dexterity + " Intelligence: " + Zondre.LevelAttributes.Intelligence + "\r\n\r\nTotal Attributes:\r\nStrength: " + Zondre.TotalAttributes().Strength + " Dexterity: " + Zondre.LevelAttributes.Dexterity + " Intelligence: " + Zondre.LevelAttributes.Intelligence + "\r\n\r\nRick Astely's total damage output: " + Zondre.Damage();
            Console.WriteLine(expected);
            //Act
            string actual = Zondre.Display();

        }
    }
}