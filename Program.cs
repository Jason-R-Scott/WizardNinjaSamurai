using System;

namespace WizardNinjaSamurai {
    class Program {
        static void Main (string[] args) {

            Wizard gandalf = new Wizard ("Gandalf");
            Samurai musashi = new Samurai ("Myamoto Musashi");
            Samurai yojimbo = new Samurai ("Yojimbo");
            Ninja kasumi = new Ninja ("Kasumi Goto");

            kasumi.Steal (gandalf);
            kasumi.Vanish ();

            Console.WriteLine (gandalf.Health);

            yojimbo.DeathBlow (target: kasumi);

            Console.WriteLine (kasumi.Health);

            gandalf.Heal (target: kasumi);

            Console.WriteLine (kasumi.Health);
        }
    }
}