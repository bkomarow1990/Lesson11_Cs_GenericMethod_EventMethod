using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_Anmal
{
    class Animal
    {
        readonly int MinHungry;
        int hungry;
        public event EventHandler Feed;
        public int Hungry { 
            get => hungry;
            set
            {
                if (hungry < MinHungry)
                {
                    Console.WriteLine("Want to eat");
                    Eat();
                    Feed?.Invoke(this, null);
                }
                else {
                    this.hungry = value;
                }
                
            }
        }
        public Animal(int MinHungry = 100, int hungry=500)
        {
            Hungry = hungry;
            this.MinHungry = MinHungry;
            
        }
        public void Eat() {

            this.Hungry += 10;
        }
        public void Run() {
            if (hungry == MinHungry )
            {
                Console.WriteLine("Sleep");
                return;
            }
            this.Hungry += 10;
            
        }
    }
}
