namespace WizardNinjaSamurai
{
    public class Human
    {
        public string Name { get; set; }
        public int Strength { get; set; } = 3;
        public int Intelligence { get; set; } = 3;
        public int Dexterity { get; set; } = 3;
        public int Health { get; set; } = 100;

        public Human (string name)
        {
            Name = name;
        }
        public Human (string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        public void Attack (Human target)
        {
            target.Health -= 5 * Strength;
        }
    }
}