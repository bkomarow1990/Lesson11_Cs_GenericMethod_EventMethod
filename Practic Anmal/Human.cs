using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_Anmal
{
    class Human
    {
        public string Name { get; set; }
        public Human(string name="NoName")
        {
            Name = name;
        }
        public void Feed(object sender, EventArgs e)
        {
            Animal animal = sender as Animal;
            if (animal != null)
            {
                animal.Eat();
                Console.WriteLine($"Animal feeded now have hungry: {animal.Hungry}");
                
            }

        }
    }
}
