namespace TamagochiElcom
{
    internal class Tamagochi : ITamagochi
    {
        private int hunger;
        private int fatigue;
        private int health;
        private int happiness;
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

        public int Happiness
        {
            get { return happiness; }
            set { happiness = ValidateValue(value); }
        }

        public Tamagochi()
        {
            Name = "Standard Name";
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
            Happiness = 10;
        }

        public Tamagochi(string name)
        {
            Name = name;
            Health = 10;
            Hunger = 0;
            Fatigue = 0;
            Happiness = 10;
        }

        public void Feed()
        {
            if (Hunger == 0)
            {
                Health--;
            }
            Hunger--;
            CheckStatus();
        }

        public void Play()
        {
            Fatigue++;
            CheckStatus();
        }

        public void Sleep()
        {
            Fatigue = 0;
            if (Hunger != 10)
            {
                Health++;
            }
            Hunger++;
            CheckStatus();
        }
        public void Heal()
        {
            Health = 10;
            Fatigue += 5;
            Hunger += 5;
            CheckStatus();
        }

        private void CheckStatus()
        {
            if (Hunger == 10)
            {
                Health--;
            }
            if (Fatigue == 10)
            {
                Hunger++;
                Health--;
            }
            if (Fatigue > 4)
            {
                Happiness--;
            }
            else
            {
                Happiness++;
            }
            if(Happiness == 0)
            {
                Health--;
            }
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
