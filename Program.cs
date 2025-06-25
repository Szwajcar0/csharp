using c_;
using System.Runtime.InteropServices;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
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

            
            Console.WriteLine($"These are his moves");
            Pokemon1.showMoves();

            Console.WriteLine("Now make a battle");
            Console.ReadLine();
            Pokemon1.Battle(EnemyPokemon1);

            Console.WriteLine("This time u won!");

            Console.WriteLine("Start your journey, Where do you want to go first?");
            Console.WriteLine("1.Pallet Town");
            Console.WriteLine("2.Viridian City");
            Console.WriteLine("3.Pewter City");
            
            string location = Console.ReadLine();
            string currentLocation = null;
            switch(location)
            {
                case "1":
                    Console.WriteLine("You are in Pallet Town, where your journey begins!");
                    currentLocation = "Pallet Town";
                    break;
                case "2":
                    Console.WriteLine("You are in Viridian City, known for its Pokémon Center.");
                    currentLocation = "Viridian City";
                    break;
                case "3":
                    Console.WriteLine("You are in Pewter City, home of the first Gym Leader.");
                    currentLocation = "Pewter City";
                    break;
                default:
                    Console.WriteLine("Unknown location. Please choose a valid place.");
                    break;
            }

            Console.WriteLine($"Now you are in {currentLocation}");
            Console.WriteLine("1.go to route 1");
            Console.WriteLine("2.go to route 2");
            Console.WriteLine("3.Fight gym leader");
            location = Console.ReadLine();
            switch (location)
            {
                case "1":
                    Console.WriteLine("You are in route 1, where you can catch wild Pokémon!");
                    break;
                    case "2":
                    Console.WriteLine("You are in route 2, where you can find more wild Pokémon!");
                    break;
                    case "3":
                    Console.WriteLine("You are ready to fight the gym leader!");
                    
                    break;
            }
            if (location == "1" || location == "2")
            {
                Console.WriteLine("You can catch wild Pokémon here!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.WriteLine("You caught a wild Pokémon!");
            }
            else if (location == "3")
            {
                int yesno = Console.Read();
                Console.WriteLine("Ready to fight?");
                Console.WriteLine("1.yes");
                Console.WriteLine("2.no");
                if(yesno == 1)
                {
                    Pokemon1.Battle(EnemyPokemon1);
                }
               
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }









        }
    }
}


