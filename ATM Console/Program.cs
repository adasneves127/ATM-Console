using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace ATM_Console
{
    class Program
    {
        

        public static string hash;
        public static string user;
        public static long balU = 0;
        public static string userhash = "";
        public static long Depwith = 0;
        public static int Size = 30;
        public static string[] names = new string[Size];
        public static string[] pins = new string[Size];
        public static long[] bal = new long[Size];
        public static int CurrentUser = Size + 1;
        public static readonly string ManagerPin = "?8?e?s??0?O9?[{?#???r??y???";


        static void Main(string[] args)
        {
            

            //Allows non-english Characters onto the console
            Console.OutputEncoding = Encoding.UTF8;

            //full screen the terminal
            SendKeys.SendWait("{F11}");



            //Writes the Splash Screen "Bank Of Pilla, System Booting"
            Console.WriteLine(@" /$$$$$$$                      /$$                        /$$$$$$        /$$$$$$$  /$$$$$$ /$$       /$$        /$$$$$$                                             
| $$__  $$                    | $$                       /$$__  $$      | $$__  $$|_  $$_/| $$      | $$       /$$__  $$                                            
| $$  \ $$  /$$$$$$  /$$$$$$$ | $$   /$$        /$$$$$$ | $$  \__/      | $$  \ $$  | $$  | $$      | $$      | $$  \ $$                                            
| $$$$$$$  |____  $$| $$__  $$| $$  /$$/       /$$__  $$| $$$$          | $$$$$$$/  | $$  | $$      | $$      | $$$$$$$$                                            
| $$__  $$  /$$$$$$$| $$  \ $$| $$$$$$/       | $$  \ $$| $$_/          | $$____/   | $$  | $$      | $$      | $$__  $$                                            
| $$  \ $$ /$$__  $$| $$  | $$| $$_  $$       | $$  | $$| $$            | $$        | $$  | $$      | $$      | $$  | $$                                            
| $$$$$$$/|  $$$$$$$| $$  | $$| $$ \  $$      |  $$$$$$/| $$            | $$       /$$$$$$| $$$$$$$$| $$$$$$$$| $$  | $$                                            
|_______/  \_______/|__/  |__/|__/  \__/       \______/ |__/            |__/      |______/|________/|________/|__/  |__/                                            
                                                                                                                                                                    
                                                                                                                                                                    
                                                                                                                                                                    
  /$$$$$$                        /$$                                   /$$$$$$$                        /$$     /$$                                                  
 /$$__  $$                      | $$                                  | $$__  $$                      | $$    |__/                                                  
| $$  \__/ /$$   /$$  /$$$$$$$ /$$$$$$    /$$$$$$  /$$$$$$/$$$$       | $$  \ $$  /$$$$$$   /$$$$$$  /$$$$$$   /$$ /$$$$$$$   /$$$$$$                               
|  $$$$$$ | $$  | $$ /$$_____/|_  $$_/   /$$__  $$| $$_  $$_  $$      | $$$$$$$  /$$__  $$ /$$__  $$|_  $$_/  | $$| $$__  $$ /$$__  $$                              
 \____  $$| $$  | $$|  $$$$$$   | $$    | $$$$$$$$| $$ \ $$ \ $$      | $$__  $$| $$  \ $$| $$  \ $$  | $$    | $$| $$  \ $$| $$  \ $$                              
 /$$  \ $$| $$  | $$ \____  $$  | $$ /$$| $$_____/| $$ | $$ | $$      | $$  \ $$| $$  | $$| $$  | $$  | $$ /$$| $$| $$  | $$| $$  | $$                              
|  $$$$$$/|  $$$$$$$ /$$$$$$$/  |  $$$$/|  $$$$$$$| $$ | $$ | $$      | $$$$$$$/|  $$$$$$/|  $$$$$$/  |  $$$$/| $$| $$  | $$|  $$$$$$$       /$$      
 \______/  \____  $$|_______/    \___/   \_______/|__/ |__/ |__/      |_______/  \______/  \______/    \___/  |__/|__/  |__/ \____  $$      |__/      
           /$$  | $$                                                                                                         /$$  \ $$                              
          |  $$$$$$/                                                                                                        |  $$$$$$/                              
           \______/                                                                                                          \______/                               ");

            //Writes to the console that it is making variables
            Console.Write("Creating Variables ");




            //Tells the program to wait for 750 miliseconds
            Thread.Sleep(750);

            //Clears the console
            Console.Clear();

            /// <summary>
            /// Writes the "Bank of Pilla, System Booting.."
            /// </summary>
            /// <param name="args"></param>
            Console.WriteLine(@" /$$$$$$$                      /$$                        /$$$$$$        /$$$$$$$  /$$$$$$ /$$       /$$        /$$$$$$                                             
| $$__  $$                    | $$                       /$$__  $$      | $$__  $$|_  $$_/| $$      | $$       /$$__  $$                                            
| $$  \ $$  /$$$$$$  /$$$$$$$ | $$   /$$        /$$$$$$ | $$  \__/      | $$  \ $$  | $$  | $$      | $$      | $$  \ $$                                            
| $$$$$$$  |____  $$| $$__  $$| $$  /$$/       /$$__  $$| $$$$          | $$$$$$$/  | $$  | $$      | $$      | $$$$$$$$                                            
| $$__  $$  /$$$$$$$| $$  \ $$| $$$$$$/       | $$  \ $$| $$_/          | $$____/   | $$  | $$      | $$      | $$__  $$                                            
| $$  \ $$ /$$__  $$| $$  | $$| $$_  $$       | $$  | $$| $$            | $$        | $$  | $$      | $$      | $$  | $$                                            
| $$$$$$$/|  $$$$$$$| $$  | $$| $$ \  $$      |  $$$$$$/| $$            | $$       /$$$$$$| $$$$$$$$| $$$$$$$$| $$  | $$                                            
|_______/  \_______/|__/  |__/|__/  \__/       \______/ |__/            |__/      |______/|________/|________/|__/  |__/                                            
                                                                                                                                                                    
                                                                                                                                                                    
                                                                                                                                                                    
  /$$$$$$                        /$$                                   /$$$$$$$                        /$$     /$$                                                  
 /$$__  $$                      | $$                                  | $$__  $$                      | $$    |__/                                                  
| $$  \__/ /$$   /$$  /$$$$$$$ /$$$$$$    /$$$$$$  /$$$$$$/$$$$       | $$  \ $$  /$$$$$$   /$$$$$$  /$$$$$$   /$$ /$$$$$$$   /$$$$$$                               
|  $$$$$$ | $$  | $$ /$$_____/|_  $$_/   /$$__  $$| $$_  $$_  $$      | $$$$$$$  /$$__  $$ /$$__  $$|_  $$_/  | $$| $$__  $$ /$$__  $$                              
 \____  $$| $$  | $$|  $$$$$$   | $$    | $$$$$$$$| $$ \ $$ \ $$      | $$__  $$| $$  \ $$| $$  \ $$  | $$    | $$| $$  \ $$| $$  \ $$                              
 /$$  \ $$| $$  | $$ \____  $$  | $$ /$$| $$_____/| $$ | $$ | $$      | $$  \ $$| $$  | $$| $$  | $$  | $$ /$$| $$| $$  | $$| $$  | $$                              
|  $$$$$$/|  $$$$$$$ /$$$$$$$/  |  $$$$/|  $$$$$$$| $$ | $$ | $$      | $$$$$$$/|  $$$$$$/|  $$$$$$/  |  $$$$/| $$| $$  | $$|  $$$$$$$       /$$       /$$      
 \______/  \____  $$|_______/    \___/   \_______/|__/ |__/ |__/      |_______/  \______/  \______/    \___/  |__/|__/  |__/ \____  $$      |__/      |__/      
           /$$  | $$                                                                                                         /$$  \ $$                              
          |  $$$$$$/                                                                                                        |  $$$$$$/                              
           \______/                                                                                                          \______/                               ");

            //Writes that it is restoring from previous session
            Console.Write("Restoring From Previous Session");

            Thread.Sleep(750);
            Console.Clear();

            Bop2();

            Console.Clear();
            while (true)
            {
                Bop();
                Console.WriteLine("Please Enter your Pin, or press N for a new user");
                Console.ForegroundColor = ConsoleColor.Black;

                string inputString = Console.ReadLine();
                byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                hash = System.Text.Encoding.ASCII.GetString(data);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < Size; i++)
                {
                    if (hash == pins[i])
                    {
                        CurrentUser = i;
                        UserChoice();
                    }

                }

               
                if (hash == ManagerPin)
                {
                    Form management = new Manage();
                    management.Show();
                    while (management.IsAccessible)
                    { }

                   
                }

                if (hash == @"??S??-??~??\?pP?l?4)???6?=?")
                {
                New_User:
                    long startb = 0;
                    Console.WriteLine("New User");
                    Console.WriteLine("Please Enter Your New Pin");
                    inputString = Console.ReadLine();
                    data = System.Text.Encoding.ASCII.GetBytes(inputString);
                    data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                    hash = System.Text.Encoding.ASCII.GetString(data);
                    Console.WriteLine("What is your name?");
                    string inp = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("What is your starting Balance");
                        startb = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Balance is not a number");
                        goto New_User;
                    }
                    for (int i = 0; i < Size; i++)
                    {
                        if (hash == pins[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Account Pin " + inputString + " is already in use. Please Choose another.");
                            Console.ForegroundColor = ConsoleColor.Black;
                            goto New_User;
                        }
                    }
                    for (int i = 0; i < Size; i++)
                    {
                        if (pins[i] == "")
                        {
                            pins[1] = hash;
                            names[i] = inp;
                            bal[i] = startb;
                        }

                    }
                }
                Console.Clear();
            }
        }
        static void UserChoice()
        {
            bool Logout = false;
            while (Logout == false)
            {
            Userstart:
                Bop();
                Console.WriteLine("Welcome " + user);
                Console.Write("Balance: ");
                if (balU < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(bal[CurrentUser]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(bal[CurrentUser]);
                }

                Console.WriteLine("Current Options: ");
                Console.WriteLine("\t1- Deposit\n\r\t2- Withdraw\n\r\t3- Log Out");
                int option = Console.Read();
                if (option == 1)
                {
                    Console.WriteLine("Please enter an amount");
                    try
                    {
                        Depwith = Console.Read();

                        Console.WriteLine("Please Confirm: Deposit of: " + Depwith + "[Y]es, or [N]o");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            bal[CurrentUser] += Depwith;
                        }
                        else
                        {
                            goto Userstart;
                        }

                    }
                    catch (FormatException)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not a number. Please Try again");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Userstart;
                    }


                }
                if (option == 2)
                {
                    Console.WriteLine("Please enter an amount");
                    try
                    {
                        Depwith = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (FormatException)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input is not a number. Please Try again");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto Userstart;
                    }
                    if (Depwith > balU)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Warning: This Operation will cause you to be in debt. Please Type the following sentence to confirm.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The quick brown fox jumped over the lazy dog");
                        String Conf = Console.ReadLine();
                        if (Conf.ToLower() != "the quick brown fox jumped over the lazy dog")
                        {
                            goto Userstart;
                        }

                    }
                    balU -= Depwith;
                }
                if (option == 3)
                {
                    Logout = true;
                }
            }

        }
        static void Bop()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@" /$$$$$$$                      /$$                        /$$$$$$        /$$$$$$$  /$$$$$$ /$$       /$$        /$$$$$$ ");
            Console.WriteLine(@"| $$__  $$                    | $$                       /$$__  $$      | $$__  $$|_  $$_/| $$      | $$       /$$__  $$");
            Console.WriteLine(@"| $$  \ $$  /$$$$$$  /$$$$$$$ | $$   /$$        /$$$$$$ | $$  \__/      | $$  \ $$  | $$  | $$      | $$      | $$  \ $$");
            Console.WriteLine(@"| $$$$$$$  |____  $$| $$__  $$| $$  /$$/       /$$__  $$| $$$$          | $$$$$$$/  | $$  | $$      | $$      | $$$$$$$$");
            Console.WriteLine(@"| $$__  $$  /$$$$$$$| $$  \ $$| $$$$$$/       | $$  \ $$| $$_/          | $$____/   | $$  | $$      | $$      | $$__  $$");
            Console.WriteLine(@"| $$  \ $$ /$$__  $$| $$  | $$| $$_  $$       | $$  | $$| $$            | $$        | $$  | $$      | $$      | $$  | $$");
            Console.WriteLine(@"| $$$$$$$/|  $$$$$$$| $$  | $$| $$ \  $$      |  $$$$$$/| $$            | $$       /$$$$$$| $$$$$$$$| $$$$$$$$| $$  | $$");
            Console.WriteLine(@"|_______/  \_______/|__/  |__/|__/  \__/       \______/ |__/            |__/      |______/|________/|________/|__/  |__/");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }


        static void Bop2()
        {
            Console.WriteLine(@" /$$$$$$$                      /$$                        /$$$$$$        /$$$$$$$  /$$$$$$ /$$       /$$        /$$$$$$                                             
| $$__  $$                    | $$                       /$$__  $$      | $$__  $$|_  $$_/| $$      | $$       /$$__  $$                                            
| $$  \ $$  /$$$$$$  /$$$$$$$ | $$   /$$        /$$$$$$ | $$  \__/      | $$  \ $$  | $$  | $$      | $$      | $$  \ $$                                            
| $$$$$$$  |____  $$| $$__  $$| $$  /$$/       /$$__  $$| $$$$          | $$$$$$$/  | $$  | $$      | $$      | $$$$$$$$                                            
| $$__  $$  /$$$$$$$| $$  \ $$| $$$$$$/       | $$  \ $$| $$_/          | $$____/   | $$  | $$      | $$      | $$__  $$                                            
| $$  \ $$ /$$__  $$| $$  | $$| $$_  $$       | $$  | $$| $$            | $$        | $$  | $$      | $$      | $$  | $$                                            
| $$$$$$$/|  $$$$$$$| $$  | $$| $$ \  $$      |  $$$$$$/| $$            | $$       /$$$$$$| $$$$$$$$| $$$$$$$$| $$  | $$                                            
|_______/  \_______/|__/  |__/|__/  \__/       \______/ |__/            |__/      |______/|________/|________/|__/  |__/                                            
                                                                                                                                                                    
                                                                                                                                                                    
                                                                                                                                                                    
  /$$$$$$                        /$$                                   /$$$$$$$                        /$$     /$$                                                  
 /$$__  $$                      | $$                                  | $$__  $$                      | $$    |__/                                                  
| $$  \__/ /$$   /$$  /$$$$$$$ /$$$$$$    /$$$$$$  /$$$$$$/$$$$       | $$  \ $$  /$$$$$$   /$$$$$$  /$$$$$$   /$$ /$$$$$$$   /$$$$$$                               
|  $$$$$$ | $$  | $$ /$$_____/|_  $$_/   /$$__  $$| $$_  $$_  $$      | $$$$$$$  /$$__  $$ /$$__  $$|_  $$_/  | $$| $$__  $$ /$$__  $$                              
 \____  $$| $$  | $$|  $$$$$$   | $$    | $$$$$$$$| $$ \ $$ \ $$      | $$__  $$| $$  \ $$| $$  \ $$  | $$    | $$| $$  \ $$| $$  \ $$                              
 /$$  \ $$| $$  | $$ \____  $$  | $$ /$$| $$_____/| $$ | $$ | $$      | $$  \ $$| $$  | $$| $$  | $$  | $$ /$$| $$| $$  | $$| $$  | $$                              
|  $$$$$$/|  $$$$$$$ /$$$$$$$/  |  $$$$/|  $$$$$$$| $$ | $$ | $$      | $$$$$$$/|  $$$$$$/|  $$$$$$/  |  $$$$/| $$| $$  | $$|  $$$$$$$       /$$       /$$       /$$
 \______/  \____  $$|_______/    \___/   \_______/|__/ |__/ |__/      |_______/  \______/  \______/    \___/  |__/|__/  |__/ \____  $$      |__/      |__/      |__/
           /$$  | $$                                                                                                         /$$  \ $$                              
          |  $$$$$$/                                                                                                        |  $$$$$$/                              
           \______/                                                                                                          \______/                               ");
        }

        
    }
}