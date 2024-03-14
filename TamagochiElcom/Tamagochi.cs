using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiElcom
{
    internal class Tamagochi : ITamagochi
    {
        private int hunger;
        private int fatigue;
        private int health;
        public string Name { get; set; }
        public int Hunger
        {
            get { return hunger; }
            set { hunger = ValidateValue(value); }
        }

        public int Fatigue
        {
            get { return fatigue; }
            set { fatigue = ValidateValue(value); }
        }

        public int Health
        {
            get { return health; }
            set { health = ValidateValue(value); }
        }

        public Tamagochi()
        {
            Name = "Standart Name";
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
        }

        public Tamagochi(string name)
        {
            Name = name;
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
        }
       
        public void Feed()
        {
            if (Hunger == 0)
                Health--;
            Hunger -= 4;
        }

        public void Play()
        {
            Fatigue++;
            Hunger++;
            if (Fatigue == 10)
            {
                Health--;
            }
        }

        public void Sleep()
        {
            Fatigue = 0;
            if (Hunger < 6)
            {
                Health++;
            }
            Hunger += 4;
        }

        private int ValidateValue(int value)
        {
            if (value < 0)
            {
                return 0;
            }
            else if (value > 10)
            {
                return 10;
            }
            else
            {
                return value;
            }
        }
    }
}
