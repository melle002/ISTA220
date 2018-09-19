using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;

namespace exercise6MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            string m_start;
            string m_mission;
            //string m_trans;
            //string m_option;

            Console.Title = "King of Battle!!!"; //Labels the title of the Window to King of Balltle!!!
            
       
            string t1 = "╔═════════════════════════════════════════════════════════╗";
            string t2 = "║  *****   *******  ***         *        ******* ******** ║";        
            string t3 = "║  *    *  *        *   *       *        *       *        ║";
            string t4 = "║  *    *  ******   *    *      *        *****   *        ║";
            string t5 = "║  *****   *        *    *      *        *       *   **** ║";
            string t6 = "║  *    *  *        *   *       *        *       *      * ║";   //creates title screen
            string t7 = "║  *     * *******  ***         ******** ******* ******** ║";
            string t8 = "╚═════════════════════════════════════════════════════════╝";
            string s1 = "King of Battle!!!"; // subtitle
            

            Console.BackgroundColor = ConsoleColor.DarkRed; // changes title on screen to artillery colors
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            

            Console.SetCursorPosition((Console.WindowWidth - t1.Length) / 2, Console.CursorTop);  // centers and writes title screen
            Console.WriteLine(t1);
            Console.SetCursorPosition((Console.WindowWidth - t2.Length) / 2, Console.CursorTop);
            Console.WriteLine(t2);
            Console.SetCursorPosition((Console.WindowWidth - t3.Length) / 2, Console.CursorTop);
            Console.WriteLine(t3);
            Console.SetCursorPosition((Console.WindowWidth - t4.Length) / 2, Console.CursorTop);
            Console.WriteLine(t4);
            Console.SetCursorPosition((Console.WindowWidth - t5.Length) / 2, Console.CursorTop);
            Console.WriteLine(t5);
            Console.SetCursorPosition((Console.WindowWidth - t6.Length) / 2, Console.CursorTop);
            Console.WriteLine(t6);
            Console.SetCursorPosition((Console.WindowWidth - t7.Length) / 2, Console.CursorTop);
            Console.WriteLine(t7);
            Console.SetCursorPosition((Console.WindowWidth - t8.Length) / 2, Console.CursorTop);
            Console.WriteLine(t8);


            Console.SetCursorPosition((Console.WindowWidth - s1.Length) / 2, Console.CursorTop);  // centers and writes subtitle
            Console.WriteLine(s1);


            Console.BackgroundColor = ConsoleColor.Black; // changes back to default colors
            Console.ForegroundColor = ConsoleColor.White;

            StartMenu();

            void StartMenu()
            {
                string m1 = "ENTER:(1) | Exit:(2)" ; // subtitle menu text

                Console.SetCursorPosition((Console.WindowWidth - m1.Length) / 2, Console.CursorTop); // centers and writes subtitle menu text
                Console.WriteLine(m1);

                m_start = Console.ReadLine();

                switch (m_start) // provides argument to start or exit

                {

                    case "1": // if user input == "1" then start method is called

                        Intro();

                        break;

                    case "2":// if user input == "2" then exit method is called

                        Exit();

                        break;

                    default:

                        Console.WriteLine($"Standing orders are press 1 to enter or 2 to exit!"); // default message displayed when user input does not follow instructions
                                                
                        break;

                }

            }

            void Exit()
            {
                Environment.Exit(0);
            }

            void Intro()
            {

                string i1 = "╔═════════════════════╗";
                string i2 = "║                     ║";
                string i3 = "║ CHOOSE YOUR MISSION ║";
                string i4 = "║                     ║";    //  ┌  └    ┬    ─    ┤    ┼     ├     ┐╟╟│   ┐  └  ┘
                string i5 = "╚═════════════════════╝";
                string i6 = "┌─────────────────────┐";
                string i7 = "│ Air Assault Raid(1) │";
                string i8 = "├─────────────────────┤";
                string i9 = "│  Fire For Effect(2) │";
                string i10 = "└─────────────────────┘";


                Console.BackgroundColor = ConsoleColor.DarkRed; // changes Intro Menu to artillery colors
                Console.ForegroundColor = ConsoleColor.DarkYellow;



                Console.SetCursorPosition((Console.WindowWidth - i1.Length) / 2, Console.CursorTop);  // centers and writes intro menu
                Console.WriteLine(i1);
                Console.SetCursorPosition((Console.WindowWidth - i2.Length) / 2, Console.CursorTop);
                Console.WriteLine(i2);
                Console.SetCursorPosition((Console.WindowWidth - i3.Length) / 2, Console.CursorTop);
                Console.WriteLine(i3);
                Console.SetCursorPosition((Console.WindowWidth - i4.Length) / 2, Console.CursorTop);
                Console.WriteLine(i4);
                Console.SetCursorPosition((Console.WindowWidth - i5.Length) / 2, Console.CursorTop);
                Console.WriteLine(i5);
                Console.SetCursorPosition((Console.WindowWidth - i6.Length) / 2, Console.CursorTop);
                Console.WriteLine(i6);
                Console.SetCursorPosition((Console.WindowWidth - i7.Length) / 2, Console.CursorTop);
                Console.WriteLine(i7);
                Console.SetCursorPosition((Console.WindowWidth - i8.Length) / 2, Console.CursorTop);
                Console.WriteLine(i8);
                Console.SetCursorPosition((Console.WindowWidth - i9.Length) / 2, Console.CursorTop);
                Console.WriteLine(i9);
                Console.SetCursorPosition((Console.WindowWidth - i10.Length) / 2, Console.CursorTop);
                Console.WriteLine(i10);


                Console.BackgroundColor = ConsoleColor.Black; // changes console back to default colors
                Console.ForegroundColor = ConsoleColor.White;

                m_mission = Console.ReadLine();

                switch (m_mission)
                {
                    case("1"):

                        Aaslt();


                        break;

                    case ("2"):

                        FireMission();

                        break;

                    default:

                        Console.WriteLine("Standing Orders are Press (1) for Air Assault or (2) for Fire For Effect");
                        break;


                }

                
            }

            void Aaslt()
            {


                var myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = @"C:\Users\micha\source\repos\exercise6MilitaryUnit\exercise6MilitaryUnit\Resources\helicopter.wav";
                myPlayer.PlaySync();

                Console.WriteLine();

                Soldier Pilots = new Soldier(); //CREATES NEW PILOTS
                Pilots.Loading("Pilot Loaded");  //PILOTS LOADING INTO HELICOPTER

                Helicopter UH60s = new Helicopter();//CREATES UH60S
                UH60s.StartEngine("WOP WOP WOP");

                UH60s.Land(); //HELICOPTERS LAND FOR PERSONNELL PICK UP

                Soldier RedLegs= new Soldier();//CREATES ADVANCE PARTY
                RedLegs.Loading("Advance Party Loads The Bird");

                UH60s.Hover(); //HELICOPTERS HOVER OVER LOADS

                Equipment A22bags = new Equipment(); //CREATES A22 BAGS TO CARRY AMMO
                Weapons Howitzers = new Weapons(); //CREATES GUNS

                UH60s.Loading("Hooking Up Guns And Equipment");
                UH60s.Unloading("Dropping Equipment");
                UH60s.Land();

                RedLegs.Unloading("Derigging Guns And Placing Into Action!");

                UH60s.StopEngine("Buuuuurrrrrrr");

                Soldier FO = new Soldier();
                FO.Cff();

                Soldier FDC = new Soldier();
                FDC.Compute();
                FDC.Transmit();


                Soldier Gunline = new Soldier();
                Gunline.Loading("C L A N K");
                Gunline.Ready();
                FO.Fire();

                var myPlayer2 = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = @"C:\Users\micha\source\repos\exercise6MilitaryUnit\exercise6MilitaryUnit\Resources\Boom.wav";
                myPlayer.PlaySync();









            }
            void FireMission()
            {
                Console.WriteLine();

                Soldier FO = new Soldier();
                FO.Cff();

                Soldier FDC = new Soldier();
                FDC.Compute();
                FDC.Transmit(); 
            

                Soldier Gunline = new Soldier();
                Gunline.Loading("C L A N K");
                Gunline.Ready();
                FO.Fire();

                var myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = @"C:\Users\micha\source\repos\exercise6MilitaryUnit\exercise6MilitaryUnit\Resources\Boom.wav";
                myPlayer.PlaySync();
                
                
            }
        }


    }
}
