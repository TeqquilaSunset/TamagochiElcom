namespace TamagochiElcom
{
    internal interface ITamagochi
    {
        string Name { get; set; }
        int Hunger { get; set; }
        int Fatigue { get; set; }
        int Health { get; set; }
        void Feed();
        void Play();
        void Sleep();
    }
}
