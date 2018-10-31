namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) :base(name)
        {
            Dexterity = 175;
        }

        public void Steal(Human target) 
        {
            this.Attack(target);
            this.Health += 10;
        }

        public void Vanish() => this.Health -= 15;
    }
}