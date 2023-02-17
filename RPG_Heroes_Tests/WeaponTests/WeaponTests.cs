using ConsoleApp1.Hero.Classes;
using ConsoleApp1.RPG_Heroes;
using ConsoleApp1.RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_Tests.WeaponTests
{
    public class WeaponTests
    {
        [Fact]
        public void CreateWeaponTest_CreatesWeaponWithName()
        {
            // Arrange
            Weapon weapon = new Weapon("Sword", 1, 15, Weapon.WeaponTypes.Sword);

            // Assert
            Assert.Equal("Sword", weapon.Name);
        }

        [Fact]
        public void CreateWeaponTest_CreatesWeaponWithRequiredLevel()
        {
            // Arrange
            Weapon weapon = new Weapon("Sword", 1, 15, Weapon.WeaponTypes.Sword);

            // Assert
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void CreateWeaponTest_CreatesWeaponWithWeaponDamage()
        {
            // Arrange
            Weapon weapon = new Weapon("Sword", 1, 15, Weapon.WeaponTypes.Sword);

            // Assert
            Assert.Equal(15, weapon.WeaponDamage);
        }

        [Fact]
        public void CreateWeaponTest_CreatesWeaponWithWeaponType()
        {
            // Arrange
            Weapon weapon = new Weapon("Sword", 1, 15, Weapon.WeaponTypes.Sword);

            // Assert
            Assert.Equal(Weapon.WeaponTypes.Sword, weapon.WeaponType);
        }


        [Fact]
        public void EquipWeaponTest_EquipsWeapon()
        {
            // Arrange
            Hero hero = new Warrior("Zondre");
            Weapon Weapon = new Weapon("Axe", 1, 15, Weapon.WeaponTypes.Axe);

            // Act
            hero.EquipItem(Weapon);
            Weapon expectedWeapon = (Weapon)hero.equipment[Weapon.Slot.Weapon];

            // Assert
            Assert.Equivalent(Weapon, expectedWeapon);
        }
    }
}
