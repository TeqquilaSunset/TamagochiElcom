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
            Name = "Standard Name";
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
            Health++;
            Hunger++;
            CheckStatus();
        }

        private void CheckStatus()
        {
            if (Hunger >= 10)
            {
                Health--;
            }
            if (Fatigue >= 10)
            {
                Hunger++;
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
