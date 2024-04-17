using Bogus;
using System.Text.Json;

namespace CodeGenSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use the PersonEntity that's generated
            var generator = new Faker<PersonEntity>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.Age, f => f.Random.Number(18, 100));

            var people = generator.Generate(25);
            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
