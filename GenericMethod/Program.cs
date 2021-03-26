using System;
using System.Collections.Generic;

namespace GenericMethod
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Busy()
        {
            Console.WriteLine($"{Name} is busy");
        }
        public override string ToString()
        {
            return $"Person: {Name}"; 
        }

       
    }
    class Worker : Person {
        public string Position { get; set; }
        public Worker(string name="NoName", string position = "NoPosition")
            :base(name)
        {
            Position = position;
        }
        public override string ToString()
        {
            return $"Worker: {Name}\t Position: {Position}"; 
        }
        public override void Busy() {
            Console.WriteLine($"Worker {Name} is working in position {Position}");
        }
    }
    class People<T> where T: Person{
        public List<T> Peoples = new List<T>();
        public void BussyAll() {
            foreach (var item in Peoples)
            {
                item.Busy();
            }
        }
    }
    class Program
    {
        static T Max<T>(T a, T b) where T : IComparable{
            return a.CompareTo(b)> 0 ? a:b;
        }
        static bool IsExistInEnum<T>(T value) where T : Enum {
            return Enum.IsDefined(typeof(T), value);
        } 
        static void Main(string[] args)
        {
            int one = 1, two = 34;
            Console.WriteLine($"Max: {Max(one,two)}");
            Console.WriteLine(IsExistInEnum((ConsoleColor) 15));
            Person p = new Person( "Olena" );
            Console.WriteLine(p);
            People<Person> people = new People<Person>();
            people.BussyAll();
            people.Peoples.Add(new Worker("Boris", "NotGai"));
            people.BussyAll();
        }
    }
}
