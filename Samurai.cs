namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        private static int Count =0;
        public Samurai(string name) :base(name)
        {
            Health = 200;
            Count += 1;
        }

        public void DeathBlow(Human target)
        {
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            else
            {
                this.Attack(target);
            }
        }

        public void Meditate() => this.Health = 200;

        public static void Formation() => System.Console.WriteLine($"{Count} Samurai are in formation");
    }
}