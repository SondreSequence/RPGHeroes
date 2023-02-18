using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.RPG_Heroes
{
    public class HeroAttributes 
    {
        public double Strength;
        public double Dexterity;
        public double Intelligence;

        /*I'm making each stat have a position in an array 
         * So I can essentially do this: int DamagingAttributePos = TotalAttributes().Values[DamageAttrPos];
         To get a mages specific damage attribute for example */
        public double[] Values
        {
            get
            {
                return new double[] { Strength, Dexterity, Intelligence };
            }
        }


        public HeroAttributes(double strength, double dexterity, double intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public HeroAttributes CombineHeroInstances(HeroAttributes heroatt1, HeroAttributes heroatt2)
        {
            HeroAttributes heroatt3 = new HeroAttributes(heroatt1.Strength + heroatt2.Strength, heroatt1.Dexterity + heroatt2.Dexterity, heroatt1.Intelligence + heroatt2.Intelligence);
            return heroatt3;
        }

        public void IncreaseStats(double increasedStrength, double increasedDexterity, double increasedIntelligence)
        {
            Strength += increasedStrength;
            Dexterity += increasedDexterity;
            Intelligence += increasedIntelligence;
        }

    }
}
