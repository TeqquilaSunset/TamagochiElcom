﻿namespace TamagochiElcom
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
            {
                Health--;
            }
            Hunger--;
        }

        public void Play()
        {
            if (Fatigue == 10)
            {
                Health--;
            }
            Fatigue++;
            Hunger++;
        }

        public void Sleep()
        {
            Fatigue = 0;
            Health++;
            Hunger++;
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
