using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
        public delegate void Function(string text);

    class Program
    {



        static void Main(string[] args)
        {
            string text;



            MyClass myclass = new MyClass();
            Console.Write("\n Write text: ");

            text = Console.ReadLine();

            Function func = myclass.Space;
            func += myclass.Reverse;
            Run run = new Run();
            run.runFunc(func, text);







            Console.ReadKey(true);


        }
    }


    class MyClass
    {


        public MyClass()
        {

        }


        public void Space(string str)
        {


            string newStr = "";

            for (int i = 0; i < str.Length; ++i)
            {
                newStr += str[i] + "_";
            }

            Console.WriteLine($" {newStr}");
        }

        public void Reverse(string str)
        {
            IEnumerable<char> c = str.Reverse();

            foreach (var reverse in c)
            {
                Console.WriteLine($"\n {reverse} ");
            }
            Console.WriteLine();
        }

    }

    class Run
    {
        public void runFunc(Function func, string text)
        {
            func.Invoke(text);
        }
    }
}
