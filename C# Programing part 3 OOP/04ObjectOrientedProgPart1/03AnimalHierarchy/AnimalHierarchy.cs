// Exercise 03 : Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful 
// constructors and methods. Dogs, frogs and cats are Animals. All animals
// can produce sound (specified by the ISound interface). Kittens and 
// tomcats are cats. All animals are described by age, name and sex. Kittens
// can be only female and tomcats can be only male. Each animal produces a
// specific sound. Create arrays of different kinds of animals and calculate
// the average age of each kind of animal using a static method (you may use LINQ).

namespace _03AnimalHierarchy
{
    using System;
    using System.Collections;
    using System.Linq;

    class AnimalHierarchy
    {
        public static void PrintSounds(Animal[] animals) 
        {
            Console.WriteLine("All animals sounds : ");
            foreach (var animal in animals)
            {
                animal.Sounds();
            }
        }

        static void Main()
        {
            TomCat tomcat = new TomCat("Penko", 5);
            Dog dog = new Dog("jonkata", 4, Gender.Male);
            Animal[] animals = 
            { 
                tomcat,
                dog, 
                new Kitten("pussycat", 1),
                new Kitten("just a pussy", 18),
                new Dog("sharo", 6, Gender.Male),
                new Frog("prince", 2, Gender.Male),
                new Frog("hermafroditko", 15),
                new TomCat("rischo", 3),
            };

            PrintSounds(animals);
            Console.WriteLine();

            // the part with selecting into groups and taking the avarage age of animals from current selected group
            var animalGroups =
            from animal in animals
            group animal by animal.GetType().Name into groups
            select new
            {
                groupName = groups.Key,
                animals = groups.ToList()
            };

            // printing the groups probably saved in dictionary
            Console.WriteLine("Grouped and taken avarage age from group members : ");
            foreach (var animalGroup in animalGroups)
            {
                Console.WriteLine("Group {0} - avarage age = {1};", animalGroup.groupName.ToString(), animalGroup.animals.Average(a => a.Age));
            }
            Console.WriteLine();

            // other avarage method for the whole Animal array
            var avarageAge = animals.Average(a => a.Age);
            Console.WriteLine("The avarage Age of all animals together is : {0};",avarageAge);
        }
    }
}
