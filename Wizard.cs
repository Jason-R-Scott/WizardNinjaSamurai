using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) :base(name)
        {
            Health = 50;
            Intelligence = 25;
        }

        public void Heal() => Health += 2 * Intelligence;
        public void Heal(Human target) => target.Health += Intelligence; 

        Random rand = new Random();

        public void Fireball(Human target) => target.Health -= rand.Next(20,51);
    }
}