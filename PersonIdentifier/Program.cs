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

            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}