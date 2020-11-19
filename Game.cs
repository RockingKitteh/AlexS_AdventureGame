using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {
        Character player = new Character();
        int catA = 1;
        int catB = 1;
        int catC = 1;
        int catD = 1;
        int dog = 1;

        public Game()
        {
            string title = @"
        ╦╔═┬┌┬┐┌┬┐┌─┐┌┐┌  ╔═╗┌┬┐┬  ┬┌─┐┌┐┌┌┬┐┬ ┬┬─┐┌─┐┬
        ╠╩╗│ │  │ ├┤ │││  ╠═╣ ││└┐┌┘├┤ │││ │ │ │├┬┘├┤ │
        ╩ ╩┴ ┴  ┴ └─┘┘└┘  ╩ ╩─┴┘ └┘ └─┘┘└┘ ┴ └─┘┴└─└─┘o
        ";
            Console.WriteLine(title);
            Console.WriteLine("An epic adventure with cats!");
            Console.ReadKey();
            Console.WriteLine("Enter Character Name");
            player.name = Console.ReadLine();
            Console.WriteLine("Welcome to the adventure " + player.name + "!\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("You wake up in a softly lit clearing.");
            Choice();
            
        }
        void Choice()
        {
            Console.ReadKey();
            string input = "";
            Console.WriteLine("You look around and see an open doorway and a kitten sitting next to the door.\n");
            Console.ReadKey();
            Console.WriteLine("Will you: \nA: talk to the kitten, or \nB: go through the door?");
            input = Console.ReadLine();
            input = input.ToUpper();
            if(input == "A")
            {
                Console.WriteLine("'Hello, " + player.name + ". I and some other cats have been trapped in this maze, \nI need your help to find the rest of us and find the exit. Now, let us hurry!'");
                Console.WriteLine("\nYou exit the room and enter the maze.\n");
                Choice2();
            }
            if(input == "B")
            {
                Console.WriteLine("You exit the room and enter The Maze.\n");
                Choice2();
            }
            else
            {
                Console.WriteLine("Please enter either 'A' or 'B'.\n");
            }
        }
        void Choice2()
        {
            Console.ReadKey();
            string input2 = "";
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("You enter a ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("dark ");
            Console.ResetColor();
            Console.Write("room with two exits, one in front of you and one to your right. ");
            Console.ReadKey();
            Console.Write("\nYou you see a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("red ");
            Console.ResetColor();
            Console.Write("light in the room in front of you and see ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blue ");
            Console.ResetColor();
            Console.Write("light in the room to your right. ");
            Console.ReadKey();
            Console.Write("\nWill you: \nA: enter the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("red ");
            Console.ResetColor();
            Console.Write("room in front of you, \nB: enter the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blue ");
            Console.ResetColor();
            Console.Write("room to your right, or \nC: return to the previous room?\n");
            input2 = Console.ReadLine();
            input2 = input2.ToUpper();

            if (input2 == "A")
            {
                Console.Write("You enter the ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("red ");
                Console.ResetColor();
                Console.Write("room ahead of you.\n");
                Room2A();
            }
            if(input2 == "B")
            {
                Console.Write("You enter the ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("blue ");
                Console.ResetColor();
                Console.Write("room to your right.\n");
                Room2B();
            }
            if (input2 == "C")
            {
                Console.Write("You return to the ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("dimly-lit ");
                Console.ResetColor();
                Console.Write("room.\n");
                Console.WriteLine("---------------------------------------------------------------------------");
                Choice();
            }
            else
            {
                Console.WriteLine("Please enter either 'A', 'B', or 'C'.\n");
            }
        }
        void Room2A()
        {
            Console.ReadKey();
            string inputC1 = "";
            string input3 = "";
            
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("You enter a room lit by ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("red ");
            Console.ResetColor();
            Console.Write("light, there are three exits. \nA ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("purple ");
            Console.ResetColor();
            Console.Write("room ahead of you, a ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("green ");
            Console.ResetColor();
            Console.Write("room to your left, and the ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("dark ");
            Console.ResetColor();
            Console.Write("room behind you.\n");
            Console.ReadKey();

            if (catA == 1)
            {
                Console.WriteLine("\nYou hear a sound, you look around the room and find a kitten sitting in the corner.");
                Console.ReadKey();
                Console.WriteLine("Will you save the cat? \n(Y/N)");
                inputC1 = Console.ReadLine();
                inputC1 = inputC1.ToUpper();

                if(inputC1 == "Y")
                {
                    Console.WriteLine("You collect the kitten. The kitten thanks you.\n");
                    catA = 0;
                    player.cats++;
                }
                if(inputC1 == "N")
                {
                    Console.WriteLine("You decide to leave the kitten in the corner.\n");
                }
                else
                {
                    Console.WriteLine("Please enter either 'Y' or 'N'.\n");
                }
            }
            if(catA == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nThe room is empty.\n");
                Console.ResetColor();
                Console.ReadKey();
            }

            Console.Write("Will you: \nA: enter the ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("purple ");
            Console.ResetColor();
            Console.Write("room ahead of you, \nB: enter the ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("green ");
            Console.ResetColor();
            Console.Write("room to your left, or \nC: return to the ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("dark ");
            Console.ResetColor();
            Console.Write("room behind you?\n");
            input3 = Console.ReadLine();
            input3 = input3.ToUpper();

            if(input3 == "A")
            {
                Console.Write("You enter the ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("purple ");
                Console.ResetColor();
                Console.Write("room ahead of you.\n");
                Room3B();
            }
            if(input3 == "B")
            {
                Console.Write("You enter the ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("green ");
                Console.ResetColor();
                Console.Write("room to your left.\n");
                Room3A();
            }
            if(input3 == "C")
            {
                Console.Write("You return to the ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("dark ");
                Console.ResetColor();
                Console.Write("room behind you.\n");
                Choice2();
            }
            else
            {
                Console.WriteLine("Please enter either 'A', 'B', or 'C'.\n");
            }
        }
        void Room3A()
        {
            Console.ReadKey();
            string takedog = "";

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("You enter a room lit by ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("green ");
            Console.ResetColor();
            Console.Write("light, there is one exit to your right.\n");
            Console.ReadKey();

            if (dog == 1)
            {
                Console.Write("\nYou see a white dog wearing a pair of cat ears in the middle of the room. ");
                Console.Write("\nWill you take the dog(cat?)? \n(Y/N)");
                takedog = Console.ReadLine();
                takedog = takedog.ToUpper();

                if(takedog == "Y")
                {
                    Console.Write("You collect the dog(cat?).\n");
                    dog = 0;
                    player.dog++;
                }
                if(takedog == "N")
                {
                    Console.Write("You leave the dog(cat?) in the room.\n");
                }
                else
                {
                    Console.WriteLine("Please enter either 'Y' or 'N'.\n");
                }
            }
            if(dog == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("The room is empty.\n");
                Console.ResetColor();
                Console.ReadKey();
            }

            Console.Write("You leave the room and return to the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("red ");
            Console.ResetColor();
            Console.Write("room.\n");
            Room2A();
        }
        void Room3B()
        {
            Console.ReadKey();
            string inputC2 = "";
            
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("You enter a room lit by ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("purple ");
            Console.ResetColor();
            Console.Write("light, there is one exit behind you.\n");
            Console.ReadKey();

            if (catB == 1)
            {
                Console.WriteLine("\nYou look around the room and see a cat sitting in the middle of the room. ");
                Console.ReadKey();
                Console.Write("\nWill you save the cat? \n(Y/N)\n");
                inputC2 = Console.ReadLine();
                inputC2 = inputC2.ToUpper();

                if(inputC2 == "Y")
                {
                    Console.WriteLine("You collect the cat. The cat thanks you.\n");
                    catB = 0;
                    player.cats++;
                }
                if(inputC2 == "N")
                {
                    Console.WriteLine("You decide to leave the cat in the middle of the room.\n");
                }
                else
                {
                    Console.WriteLine("Please enter either 'Y' or 'N'.\n");
                }
            }
            if(catB == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("The room is empty.\n");
                Console.ResetColor();
                Console.ReadKey();
            }

            Console.Write("You leave the room and return to the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("red ");
            Console.ResetColor();
            Console.Write("room.\n");
            Room2A();
        }
        void Room2B()
        {
            Console.ReadKey();
            string input4 = "";

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("You enter a room lit by ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blue ");
            Console.ResetColor();
            Console.Write("light, there are three exits. \nA ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("yellow ");
            Console.ResetColor();
            Console.Write("room ahead of you, a ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("cyan ");
            Console.ResetColor();
            Console.Write("room behind you, and a ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("dark ");
            Console.ResetColor();
            Console.Write("room to your right.\n");
            Console.ReadKey();
            Console.Write("\nWill you: \nA: enter the ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("yellow ");
            Console.ResetColor();
            Console.Write("room ahead of you, \nB: enter the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("cyan ");
            Console.ResetColor();
            Console.Write("room behind you, or \nC: return to the ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("dark ");
            Console.ResetColor();
            Console.Write("room to your left?\n");
            input4 = Console.ReadLine();
            input4 = input4.ToUpper();

            if(input4 == "A")
            {
                Console.Write("You enter the ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("yellow ");
                Console.ResetColor();
                Console.Write("room ahead of you.\n");
                Room3C();
            }
            if(input4 == "B")
            {
                Console.Write("You enter the ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("cyan ");
                Console.ResetColor();
                Console.Write("room behind you.\n");
                Room3D();
            }
            if(input4 == "C")
            {
                Console.Write("You return to the ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("dark ");
                Console.ResetColor();
                Console.Write("room to your left.\n");
                Choice2();
            }
            else
            {
                Console.WriteLine("Please enter either 'A', 'B', or 'C'.\n");
            }
        }
        void Room3C()
        {
            Console.ReadKey();
            string inputC3 = "";
            string input5 = "";
            
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("You enter a room lit by a ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("yellow ");
            Console.ResetColor();
            Console.Write("light, there are two exits. \nA closed door to your right and a ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blue ");
            Console.ResetColor();
            Console.Write("room behind you.\n");
            Console.ReadKey();

            if (catC == 1)
            {
                Console.WriteLine("\nYou see a kitten standing in front of you.");
                Console.ReadKey();
                Console.WriteLine("\nWill you save the cat? \n(Y/N)");
                inputC3 = Console.ReadLine();
                inputC3 = inputC3.ToUpper();

                if(inputC3 == "Y")
                {
                    Console.WriteLine("You collect the kitten. The kitten thanks you.\n");
                    catC = 0;
                    player.cats++;
                }
                if(inputC3 == "N")
                {
                    Console.WriteLine("You leave the kitten standing in the room.\n");
                }
                else
                {
                    Console.WriteLine("Please enter either 'Y' or 'N'.\n");
                }
            }
            if(catC == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("The room is empty.\n");
                Console.ResetColor();
                Console.ReadKey();
            }

            Console.Write("\nWill you: \nA: go through the door to your right, or \nB: enter the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blue ");
            Console.ResetColor();
            Console.Write("room behind you?\n");
            input5 = Console.ReadLine();
            input5 = input5.ToUpper();

            if(input5 == "A")
            {

                if(player.cats >= 2)
                {
                    Console.WriteLine("You try to open the door but it doesn't move. However, the cats you have saved approach the door.");
                    Console.ReadKey();
                    Console.WriteLine("With a dim glow, you hear the door creak and crack open. \nYou enter the next room.\n");
                    RoomLast();
                }
                else
                {
                    Console.Write("You try to open the door but it doesn't move. You see writing on the door, it says, ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n'You have saved an insufficient amount of cats.. Return when you have saved at least two or more...'\n");
                    Console.ResetColor();
                    Room3C();
                }
            }
            if(input5 == "B")
            {
                Console.Write("You return to the ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("blue ");
                Console.ResetColor();
                Console.Write("room behind you.\n");
                Room2B();
            }
            else
            {
                Console.WriteLine("Please enter either 'A' or 'B'.\n");
            }
        }
        void RoomLast()
        {
            Console.ReadKey();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("As you enter the room you are blinded by a bright light.");
            Console.WriteLine("\nOnce your eyes are adjusted to the light you realize that you're outside in a grassy clearing. \nYou have made it out of the maze...");
            Console.ReadKey();
            Console.Write("\nYou see a figure made of light appear and apperoach you, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("'Congratulations, you have made it out of the maze.'\n");
            Console.ResetColor();
            Console.ReadKey();
            
            if (player.cats <= 3)
            {
                Console.WriteLine("The kittens you saved approach the figure, ");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n'Thank you for saving these cats, however, you did not succeed in rescuing all of them which is quite unfourtunate.'");
                Console.ResetColor();
                Console.WriteLine("The figure then dissapears along with the kittens.\n");
                Console.ReadKey();
            }
            else if(player.cats == 4)
            {
                Console.WriteLine("The kittens you saved approach the figure, ");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n'Thank you for saving these cats, you have found and rescued all four of them. \nAgain, thank you, here is a special reward for your effort.'");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("The figure holds out a hand and a gold medallion appears. \nThe figure then hands you the medallion and dissapears along with the kittens.\n");
                player.medal.awardtype = "gold";
                Console.ReadKey();
            }
            if(player.dog == 1)
            {
                Console.WriteLine("The dog(cat?) walks out in front of you, winks at you, and flies up into the sky, dissapearing out of sight.\n");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Congrats on beating the game! Here are your end game results!\n");
            Console.ReadKey();
            Console.WriteLine("Cats rescued: " + player.cats + "/4\n");
            Console.ReadKey();
            Console.WriteLine("Dog(cat?) rescued?: " + player.dog);
            Console.ReadKey();
            if (player.medal.awardtype == "gold")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nYou recieved the Gold Medal achievement for rescuing all the cats!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(player.medal.award);
                Console.ResetColor();
                Console.ReadKey();
            }

            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine("-Credits-");
            Console.WriteLine("ASCII text from http://patorjk.com/software/taag/#p=display&f=Calvin%20S&t=Kitten%20Adventure");
            Console.WriteLine("ASCII end game medal from https://ascii.co.uk/art/medal by Joan G Stark");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
        void Room3D()
        {
            Console.ReadKey(true);
            string inputC4 = "";
            
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.Write("You enter a room lit by a ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("cyan ");
            Console.ResetColor();
            Console.Write("light, there is one exit ahead of you.\n");
            Console.ReadKey();

            if (catD == 1)
            {
                Console.WriteLine("\nYou see a kitten laying in the corner of the room.");
                Console.ReadKey();
                Console.WriteLine("\nWill you save the kitten? \n(Y/N)\n");
                inputC4 = Console.ReadLine();
                inputC4 = inputC4.ToUpper();

                if (inputC4 == "Y")
                {
                    Console.WriteLine("You collect the kitten. The kitten thanks you.\n");
                    catD = 0;
                    player.cats++;
                }
                if (inputC4 == "N")
                {
                    Console.WriteLine("You leave the kitten laying in the corner.\n");
                }
                else
                {
                    Console.WriteLine("Please enter either 'Y' or 'N'.\n");
                }
            }
            if(catD == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("The room is empty.\n");
                Console.ResetColor();
                Console.ReadKey();
            }

            Console.Write("You return to the ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("blue ");
            Console.ResetColor();
            Console.Write("room ahead of you.\n");
            Room2B();
        }
    }
}
