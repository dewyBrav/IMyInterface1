using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyInterface1
{
    public class MyClassForTest
    {
        public void Message(ConsoleColor color)
        {
            //Console.ForegroundColor = color;
            Console.WriteLine("Message: {0}", GetType().FullName, Console.ForegroundColor = color);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }

    class MyClassNumberTwo:MyClassForTest, Interface1
    {
        public void Draw()
        {
            Console.WriteLine("Is Interface? and From: {0}  base: {1}", GetType().Name, GetType().BaseType);
        }
    }

    class MyClassNumberThree: MyClassForTest, Interface1
    {

        public void Draw() 
        {
            Console.WriteLine("Is Interface? and From: {0}  base: {1} ", GetType().Name, GetType().BaseType);
        }
    }

    class MyClassNumberFour: MyClassForTest
    {
        public  new void Message(ConsoleColor color)
        {
            Console.WriteLine("Message: {0}, base: {1}", GetType().FullName, GetType().BaseType, Console.ForegroundColor = color);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
