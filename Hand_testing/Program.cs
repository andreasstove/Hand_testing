using System;
using System.Net;

namespace Hand_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator _calck = new Calculator();
            string response;
            double t1;
            double t2;
            double r1;
            while(true)
            {
                Console.WriteLine("Velkommen til en lommeregner");
                Console.WriteLine("For at lægge til tryk l, for at trække fra tryk t, for at gange tryk g og for at tage eksponenten tryk e.");
                response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "L":
                        Console.WriteLine("Du valgte at lægge to tal sammen, du kan nu skrive det første tal efterfulgt af enter.");
                        t1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Du kan nu indtaste det andet til efterfulgt af enter, og det vil blive lagt sammen");
                        t2 = Convert.ToDouble(Console.ReadLine());
                        r1 = _calck.Add(t1, t2);
                        Console.WriteLine("Resultatet af {0} og {1} lagt sammen er {2}", t1, t2, r1);
                        break;
                    case "T":
                        Console.WriteLine("Du valgte at trække to tal fra hinanden, du kan nu skrive det første tal efterfulgt af enter.");
                        t1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Du kan nu indtaste det andet efterfulgt af enter, og det vil blive trukket fra");
                        t2 = Convert.ToDouble(Console.ReadLine());
                        r1 = _calck.Subtract(t1, t2);
                        Console.WriteLine("Resultatet af {0} og {1} trukket fra hinaden er {2}", t1, t2, r1);
                        break;
                    case "G":
                        Console.WriteLine("Du valgte at gange to tal med hinanden, du kan nu skrive det første tal efterfulgt af enter.");
                        t1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Du kan nu indtaste det andet efterfulgt af enter, og de vil blive ganget sammen");
                        t2 = Convert.ToDouble(Console.ReadLine());
                        r1 = _calck.Multiply(t1, t2);
                        Console.WriteLine("Resultatet af {0} og {1} ganget sammen er {2}", t1, t2, r1);
                        break;
                    case "E":
                        Console.WriteLine("Du valgte at eksponere to tal, det første tal er tallet der skal opløftes i det andet tal, du kan nu indtaste det første tal efterfulgt af enter.");
                        t1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Du kan nu indtaste det andet efterfulgt af enter, og det vil blive eksponenten på det første");
                        t2 = Convert.ToDouble(Console.ReadLine());
                        r1 = _calck.Power(t1, t2);
                        Console.WriteLine("Resultatet af {0} og {1} trukket fra hinaden er {2}", t1, t2, r1);
                        break;
                    default:
                        break;
                }


            }
        }
    }
}
