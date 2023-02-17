# RPGHeroes

RPG Heroes is a console application built in .NET that allows the user to create and manage various heroes with different attributes and items.

# Getting Started
Prerequisites
Make sure you have installed the following tools:
Visual Studio with .NET 6

# Installation
Clone the repository:
git clone https://github.com/SondreSequence/RPGHeroes.git

Open the solution file RPGHeroes.sln in Visual Studio
# Usage
The application allows the user to create heroes of different classes, including Mage, Ranger, Rogue, and Warrior, and customize their attributes and equipment. Heroes have different shared fields, such as Name, Level, LevelAttributes, Equipment, ValidWeaponTypes, and ValidArmorTypes, as well as public facing methods, including LevelUp, Equip, Damage, TotalAttributes, and Display.

# Hero Attributes
The attribute system in this application is based on the traditional Three-Stat System leaning towards a Diablo 3 implementation. Heroes have three main attributes:

Strength – determines the physical strength of the character.
Dexterity – determines the characters ability to attack with speed and nimbleness.
Intelligence – determines the characters affinity with magic.
Levelling Attributes
There is a base abstract Hero class that encapsulates all the shared functionality (fields and methods) for the hero classes. Each subclass starts at different attributes and increases at different rates when levelling up. 
