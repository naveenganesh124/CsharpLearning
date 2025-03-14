
namespace learn1
{
    class Program
    {
        static void Main(String[] args)
        {
            string characterName = "Naveen";
            int characterAge;
            characterAge = 45;
            Console.WriteLine("There oen was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Vijay";  //we can reassign the variables after sometimes.
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("but didn't like the age " + characterAge);

            Console.ReadLine();
        }

    }
}