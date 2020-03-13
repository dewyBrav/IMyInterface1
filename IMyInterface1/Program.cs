using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyInterface1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrivenedieIn();

            Console.ReadLine();
        }

        static void PrivenedieIn()
        {

            MyClassForTest[] _tset = { new MyClassForTest(), new MyClassNumberTwo(), new MyClassNumberThree(), new MyClassNumberFour() };

            foreach (MyClassForTest i in _tset)
            {
                if (i is Interface1)
                {

                    ((Interface1)i).Draw();
                }
                else
                {
                    ConsoleColor clr = ConsoleColor.Red;
                    i.Message(clr);

                }
            }
            MyClassNumberFour g = new MyClassNumberFour();
            g.Message(ConsoleColor.Green);
           
        }
    }
}
