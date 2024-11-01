using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)WRITEING IN CONSOLE , DRAWING SHAPES.
            /* Console.WriteLine("Hello world");

             Console.WriteLine("   /|");
             Console.WriteLine("  / |");
             Console.WriteLine(" /  |");
             Console.WriteLine("/___|");

             Console.ReadLine();
            */





            //2) VARIABLES
            /*
            string name = "Tom";
            int CharacterAge = 45;
            
            Console.WriteLine("There once was man named "+name);
            Console.WriteLine("He was "+CharacterAge+"y/o");

            name = "Gela";
            CharacterAge = 23;
            Console.WriteLine("He really liked the name "+ name);
            Console.WriteLine("But didnot liked being " +CharacterAge);

            Console.ReadLine();
            */






            //3)DATA TYPES
            /*
            string praza = "rene pussy licker";
            char grade = 'A';
            int age = 30;
            double decANDfloat = 3.4;
            float flt = 3;
            decimal fla = 4;
            bool isMale = true;

            Console.WriteLine(praza);
            Console.WriteLine(age+" is just number");
            Console.WriteLine("My age is: "+age);
            Console.WriteLine("My grade is: "+grade);
            Console.WriteLine("Are you male?: "+isMale);
            Console.ReadLine();
            */






            //4)WORKING WITH STRINGS
            /*
            string praza = "Rene pussy licker";

            Console.WriteLine(praza.Length);
            Console.WriteLine(praza.ToUpper());
            Console.WriteLine(praza.Contains("rene"));//true
            Console.WriteLine(praza.Contains("reneee"));//false
            Console.WriteLine(praza[0]);
            Console.WriteLine(praza.IndexOf("pussy"));
            Console.WriteLine(praza.Substring(11,6));
            Console.WriteLine(praza.Substring(praza.IndexOf("pussy")));


            Console.WriteLine(praza+" feeling good buddy");
            Console.ReadLine();
            */









            //5)WORKING WITH NUMBERS
            /*
            Console.WriteLine(30+40);
            Console.WriteLine(30/40);
            Console.WriteLine(30*40);
            Console.WriteLine(30-40);
            Console.WriteLine(30.5 - 40.23);
            Console.WriteLine(30 - 40.23);
            Console.WriteLine(Math.Max(199,101));


            int num = 5;
            num++;
            num--;
            Console.WriteLine(num);

            Console.ReadLine();
            */







            //6)GETTING USER INPUT
            /*
            Console.Write("Enter yur name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", You are " + age + " years old");
            

            Console.ReadLine();
            */





            //7)SIMPLE CALCULATOR
            /*
            Console.Write("Enter first Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double num3 = num1 + num2;

            Console.WriteLine("Your answer is: " + num3);

            Console.ReadLine();
            */






            //8)MAD LIBS GAME
            /*
            string color, plurarNoun, celebrity;

            Console.Write("Enter Color: ");
            color = Console.ReadLine();

            Console.Write("Enter plurarNoun: ");
            plurarNoun = Console.ReadLine();

            Console.Write("Enter celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("\nRoses are "+color);
            Console.WriteLine(plurarNoun+" are blue");
            Console.WriteLine("i love "+ celebrity);

            Console.ReadLine();
            */







            //9)ARRAYS
            /*
            int [] luckyNumbers = {14,42,63,24,15,6};
            luckyNumbers[0] = 900;
            string[] friends = new string[10];
            friends[0] = "Rene";
            friends[1] = "Tom";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[2]);

            Console.ReadLine();
            */




            //10)METHOS

            sayHello("rene",24);
            Console.ReadLine();

        }
        static void sayHello(string name,int age)
        {
            Console.WriteLine("Hello bitch " + name + " You are "+ age + " years old");
        }

    }
}
