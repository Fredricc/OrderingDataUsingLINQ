namespace OrderingDataUsingLINQ
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<string> { "Deer", "Sheep", "Cat", "Dog", "Bull","Donkey","Camel", "Emu", "Goat"};

            foreach (var animal in animals.OrderBy(animal => animal))
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("________________\n");

            foreach(var animal in animals.OrderByDescending(animal => animal))
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("________________\n");

            var persons = new List<Person>
            {
                new Person("Nicholas", "Mamau"),
                new Person("Ken", "Njuguna"),
                new Person("Ken", "Njenga"),
                new Person("Paul", "Kiprotech"),
                new Person("Isaac", "Soita"),
                new Person("James", "Kimani")
            };

            foreach (var person in persons.OrderBy(person => person.FirstName).ThenBy(person => person.LastName))
            {
                Console.WriteLine( $"{person.FirstName} {person.LastName}");
            }

            Console.WriteLine("________________\n");

            animals.Reverse();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
            record Person(string FirstName, string LastName);
    }
}