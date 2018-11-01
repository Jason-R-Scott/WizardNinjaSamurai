using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main (string[] args)
        {

            Wizard gandalf = new Wizard ("Gandalf");
            Samurai musashi = new Samurai ("Myamoto Musashi");
            Samurai yojimbo = new Samurai ("Yojimbo");
            Ninja kasumi = new Ninja ("Kasumi Goto");

            Human bob = new Human ("Bob");

            bob.Attack (gandalf);

            gandalf.Attack (musashi);

            System.Console.WriteLine (musashi.Health);

            System.Console.WriteLine (gandalf.Health);

            Samurai.Formation ();

            // kasumi.Steal (gandalf);
            // kasumi.Vanish ();

            // Console.WriteLine (gandalf.Health);

            // yojimbo.DeathBlow (target: kasumi);

            // Console.WriteLine (kasumi.Health);

            // gandalf.Heal (target: kasumi);

            // Console.WriteLine (kasumi.Health);
        }
    }
}