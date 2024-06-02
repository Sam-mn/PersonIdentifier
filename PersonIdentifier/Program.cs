// See https://aka.ms/new-console-template for more information
namespace PersonIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                PersonHandlar handlar = new PersonHandlar();
                Person person = handlar.CreatePerson(22, "Johanna", "Lund", 165, 65);

                handlar.SetAge(person, 33);
                handlar.SetFirstName(person, "Marcus");
                handlar.SetLastName(person, "Noah");
                handlar.SetHeight(person, 77);
                handlar.SetHeight(person, 180);

                Console.WriteLine(handlar.GetAge(person));
                Console.WriteLine(handlar.GetFirstName(person));
                Console.WriteLine(handlar.GetLastName(person));
                Console.WriteLine(handlar.GetHeight(person));
                Console.WriteLine(handlar.GetWeight(person));

                Console.WriteLine("---------------------------------------------------------------------");

                var numericInputError = new NumericInputError();
                var textInputError = new TextInputError();
                var firstError = new FirstError();
                var secondError = new SecondError();
                var thirdError = new ThirdError();

                List<UserError> errors = new List<UserError>()
                {
                    numericInputError,
                    textInputError,
                    firstError,
                    secondError,
                    thirdError,
                };

                foreach (var error in errors)
                {
                    Console.WriteLine(error.UEMessage());
                }

                Console.WriteLine("---------------------------------------------------------------------");

                var hourse = new Hourse("Joe", 150, 4, "red");
                var dog = new Dog("Dogge", 30, 2, "Bulldog");
                var hedgehog = new Hedgehog("Uffe",2, 1, 300);
                var worm = new Worm("Ebba", 1, 2, true);
                var bird = new Bird("Carl", 0.5, 1, 1);
                var wolf = new Wolf("wolffy", 20, 3, true);
                var swan = new Swan("swan", 20, 1, 10, true);
                var wolfman = new Wolfman("Kris", 10, 2, false);

                var AnimalsList = new List<Animal>()
                {
                    hourse,
                    dog,
                    hedgehog, 
                    worm,
                    bird,
                    wolf,
                    wolfman,
                    swan
                };

                foreach (var animal in AnimalsList) 
                {
                  Console.WriteLine(animal.GetType().Name);
                  animal.DoSound();
                  
                    if (animal is Wolfman wolfmanType) 
                    {
                        wolfmanType.Talk();
                    }

                    Console.WriteLine(animal.Stats());
                    Console.WriteLine("--------------------------------------------------");

                }

                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Dogs");
                var dog1 = new Dog("Dog1", 20, 2, "Bulldog");
                var dog2 = new Dog("Dog2", 15, 1, "Chihuahua");
                var dog3 = new Dog("Dog3", 25, 3, "Poodie");
                var dog4 = new Dog("Dog4", 30, 2, "Husky");

                var dogsList = new List<Dog>() { dog1, dog2, dog3, dog4 };

                var hourse1 = new Hourse("Noe", 150, 8, "White");

                //dogsList.Add(hourse1);

                foreach (var animal in AnimalsList)
                {
                    if (animal is Dog doggy)
                    {
                        Console.WriteLine(animal.Stats());
                        
                      Console.WriteLine(doggy.Hungry());
                    }
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}