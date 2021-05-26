using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.WorldOfTanks
{
    public class Tank
    {
        protected string TankName;
        protected int AmmunitionLevel;
        protected int ArmorLevel;
        protected int Maneuverability;
        public Tank (string name, int ammunition, int armor, int maneuverability)
        {
            TankName = name;
            AmmunitionLevel = ammunition;
            ArmorLevel = armor;
            Maneuverability = maneuverability;


        }

        public static bool operator *(Tank obj1, Tank obj2)
        {
            int num1=0;
            int num2=0;
            if (obj1.AmmunitionLevel > obj2.AmmunitionLevel) num1++;
            else num2++;
            if (obj1.ArmorLevel > obj2.ArmorLevel) num1++;
            else num2++;
            if (obj1.Maneuverability > obj2.Maneuverability) num1++;
            else num2++;


            if (num1 > num2) return true;
            else return false;
            
        }

        public string GetName() { return TankName; }
        public int GetAmmunitionLevel() { return AmmunitionLevel; }
        public int GetArmorLevel() { return ArmorLevel; }
        public int GetManeuverability() { return Maneuverability; }
    }

    public class T34 : Tank
    {
        
        public T34(string name, int ammunition, int armor, int maneuverability) : base (name, ammunition, armor, maneuverability)
        {

        }
    }

    public class Pantera : Tank
    {
        public Pantera(string name, int ammunition, int armor, int maneuverability) : base(name, ammunition, armor, maneuverability)
        {

        }
    }
}
