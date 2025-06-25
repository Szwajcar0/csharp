using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    public class pokemon
    {
        private string pname;
        private int plevel;
        private string ptype;

        public int hp = 100;

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        public int Plevel
        {
            get { return plevel; }
            set { plevel = value; }
        }
        public string Ptype
        {
            get { return ptype; }
            set { ptype = value; }
        }


        public class Move
        {
            public string Name { get; set; }
            public string Dmg { get; set; }

            public Move(string name, string dmg)
            {
                Name = name;
                Dmg = dmg;
            }
        }

        public Move tackle = new Move("Tackle", "10");
        public Move ember = new Move("Ember", "20");
        public Move quickAttack = new Move("Quick Attack", "10");
        public Move tailWhip = new Move("Tail Whip", "5");
        public Move thunderShock = new Move("Thunder Shock", "20");
        public Move growl = new Move("Growl", "5");
        public Move vineWhip = new Move("Vine Whip", "20");
        public Move bubble = new Move("Bubble", "20");
        public Move chuj = new Move("Chuj", "100");

        public Move[] moves1 = new Move[4];


    public pokemon(string name, int level, string type)
        {
            this.pname = name;
            this.plevel = level;
            this.ptype = type;

            if (name == "Charmander")
                moves1 = new Move[] { tackle, ember, quickAttack, chuj};
            else if (name == "Pikachu")
                moves1 = new Move[] { thunderShock, quickAttack, tailWhip, growl };
            else if (name == "Bulbasaur")
                moves1 = new Move[] { tackle, growl, vineWhip, growl };
            else if (name == "Squirtle")
                moves1 = new Move[] { tackle, tailWhip, bubble, growl };
            else if (name == "Eevee")
                moves1 = new Move[] { tackle, growl, quickAttack, growl };
            else
                throw new ArgumentException("Unknown Pokemon type");

        }

        

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {pname}, Level: {plevel}, Type: {ptype}");
        }
        public void LevelUp()
        {
            plevel++;
            Console.WriteLine($"{pname} leveled up to level {plevel}!");
        }
        public void showMoves()
        {
            for (int i = 0; i < moves1.Length; i++)
            {
                if (moves1[i] != null)
                    Console.WriteLine($"{i + 1}. {moves1[i].Name}");
            }
        }
        public void Attack(string move)
        {
            Console.WriteLine($"{pname} used {move}!");
        }

        public void Battlestage(pokemon enemy)
        {
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"| {enemy.Pname} HP: {enemy.hp}                              |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|                                               |");
            Console.WriteLine("|                                               |");
            Console.WriteLine($"|                            {pname} HP: {hp} |");
            Console.WriteLine(" -----------------------------------------------");
        }

        public void Battle(pokemon enemy)
        {
            Random random = new Random();
            

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine($"Turn {i + 1}");


                if (hp <= 0)
                {
                    Console.WriteLine($"{pname} has fainted!");
                    return;
                }
                if (enemy.hp <= 0)
                {
                    Console.WriteLine($"{enemy.Pname} has fainted!");
                    return;
                }
                else
                {

                    Console.WriteLine($"{pname} is battling against {enemy.Pname}!");
                    Battlestage(enemy);
                    Console.WriteLine("Choose move");
                    showMoves();
                    string moveChoice = Console.ReadLine();
                    if (moveChoice == "1")
                    {
                        enemy.hp -= int.Parse(moves1[0].Dmg);
                        int enemyMove = random.Next(0, 3);
                        
                        hp -= int.Parse(enemy.moves1[enemyMove].Dmg);
                    }
                    else if (moveChoice == "2")
                    {
                        enemy.hp -= int.Parse(moves1[1].Dmg);
                        int enemyMove = random.Next(0, 3);

                        hp -= int.Parse(enemy.moves1[enemyMove].Dmg);
                    }
                    else if (moveChoice == "3")
                    {
                        enemy.hp -= int.Parse(moves1[2].Dmg);
                        int enemyMove = random.Next(0, 3);

                        hp -= int.Parse(enemy.moves1[enemyMove].Dmg);
                    }
                    else if (moveChoice == "4")
                    {
                        enemy.hp -= int.Parse(moves1[3].Dmg);
                        int enemyMove = random.Next(0, 3);

                        hp -= int.Parse(enemy.moves1[enemyMove].Dmg);
                    }
                    else
                    {
                        Console.WriteLine("Invalid move choice.");
                        continue;
                    }
                }
            }
        }
    }

    public class legendary : pokemon
    {
        public legendary(string name, int level, string type) : base(name, level, type)
        {
            // Legendary Pokemon can have special moves or attributes if needed
            // For now, it just inherits from pokemon
        }
        // You can add more methods or properties specific to legendary Pokemon here
    }
}
