using c_;
using System.Runtime.InteropServices;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            string slowo = "kutas";
            Console.WriteLine("Hello, what is your name?");
            Console.WriteLine("Tell your name");
            string name = Console.ReadLine();

            void hello(string name)
            {
                Console.WriteLine($"Hello {name}");
            }
            hello(name);

            Console.WriteLine("choose your pokemon:");
            Console.WriteLine("1. Pikachu");
            Console.WriteLine("2. Bulbasaur");
            Console.WriteLine("3. Charmander");
            Console.WriteLine("4. Squirtle");

            string choice = Console.ReadLine();
            pokemon EnemyPokemon1 = null;
            pokemon Pokemon1 = null;
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose Pikachu!");
                    Pokemon1 = new pokemon("Pikachu", 5, "Electric");
                    
                    EnemyPokemon1 = new pokemon("Eevee", 5, "Normal");
                    
                    Console.WriteLine($"This is your enemy pokemon {EnemyPokemon1.Pname}");
                    break;
                case "2":
                    Console.WriteLine("You chose Bulbasaur!");
                    Pokemon1 = new pokemon("Bulbasaur", 5, "Grass/Poison");
                    
                    EnemyPokemon1 = new pokemon("Charmander", 5, "Fire");
                    
                    Console.WriteLine($"This is your enemy pokemon {EnemyPokemon1.Pname}");
                    break;
                case "3":
                    Console.WriteLine("You chose Charmander!");
                    Pokemon1 = new pokemon("Charmander", 5, "Fire");
                    
                    EnemyPokemon1 = new pokemon("Squirtle", 5, "Water");
                    
                    Console.WriteLine($"This is your enemy pokemon {EnemyPokemon1.Pname}");
                    break;
                case "4":
                    Console.WriteLine("You chose Squirtle!");
                    Pokemon1 = new pokemon("Squirtle", 5, "Water");
                    
                    EnemyPokemon1 = new pokemon("Bulbasaur", 5, "Grass/Poison");
                    
                    Console.WriteLine($"This is your enemy pokemon {EnemyPokemon1.Pname}");
                    break;
                default:
                    Console.WriteLine("There's only 4");
                    break;
            }

            //Console.WriteLine($"This is your pokemon {Pokemon1.Pname}");
            Console.WriteLine($"These are his moves");
            Pokemon1.showMoves();

            Console.WriteLine("Now make a battle");
            Console.ReadLine();
            Pokemon1.Battle(EnemyPokemon1);

            Console.WriteLine("This time u won!");









        }
    }
}


