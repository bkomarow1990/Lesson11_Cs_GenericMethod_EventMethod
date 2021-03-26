using System;

namespace Practic_Anmal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal(100,5);
            Human boris = new Human("Boris");
            cat.Feed += boris.Feed;
            cat.Run();
        }
    }
}
