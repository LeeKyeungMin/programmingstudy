using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Programmingstudy
    {
        static void Main(string[] args)
        {
            int fst= int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            int sec = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Add(fst, sec);
                    Console.WriteLine(Add(fst, sec));
                    break;

                case "-":
                    Sub(fst, sec);
                    Console.WriteLine(Sub(fst, sec));
                    break;

                case "*":
                    Multi(fst, sec);
                    Console.WriteLine(Multi(fst, sec));
                    break;

                case "/":
                    Div(fst, sec);
                    Console.WriteLine(Div(fst, sec) + "..." + R(fst, sec));
                    break;

                default:
                    break;
            }


        }

        static int Multi(int fst, int sec)
        {
            return fst * sec;
        }

        static int Add(int fst, int sec)
        {
            return fst + sec;
        }

        static int Sub(int fst, int sec)
        {
            return fst - sec;
        }

        static int Div(int fst, int sec)
        {
            return fst / sec;
        }

        static int R(int fst, int sec)
        {
            return fst % sec;
        }
    }
}