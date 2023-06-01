using Microsoft.VisualBasic;

namespace Kristina_Kulich__Application
{

    public class Homework_1
    {

        public void Task_1()
        {
            double a = 3.4;
            decimal b;
            object c;
            string d;
            long e;
            bool f;
            b = 3;
            c = b;
            d = "Name";
            e = 2348984343234;
            f = true;
            Console.WriteLine("\n" + a + "\n" + b + "\n" + c + "\n" + d + "\n" + e + "\n" + f + "\n");
        }

        public void Task_2()
        {
            Console.WriteLine("input your name:");
            string name = Console.ReadLine();
            Console.WriteLine("input your lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("input your age:");
            string age = Console.ReadLine();

            Console.WriteLine("{0}, {1}, {2}", name, lastname, age);
            Console.WriteLine
            ("\"How old are you\", - policemen asked." + "\n" + "\"{0}\", - {1} {2} answered.", age, name,
                lastname);
        }

        public void Task_3()
        {
            string a;
            string b;
            
            Console.WriteLine("Input one symbol integer:");
            Console.WriteLine("Input two symbol integer:");
            Console.WriteLine("Input three symbol integer:");

            string aa = Console.ReadLine();
            string bb = Console.ReadLine();
            string cc = Console.ReadLine();
            string final_babe = string.Join("<", aa, bb, cc);
            Console.WriteLine(final_babe);
        }

        public void Task_4()
        {
            string initial = Console.ReadLine();
            string first = initial.Substring(0, 3);
            Console.WriteLine(first);
            string second = initial.Substring(3, initial.Length-2-1);
            Console.WriteLine(second);
            string final = String.Join(null, first,second);
            Console.WriteLine(final);
        }
        public void Task_5()
        {
            Console.WriteLine("Input poem:");
            string poem = Console.ReadLine();
            Console.WriteLine(("Input adjective to change"));
            string adjective = Console.ReadLine();
            Console.WriteLine(("Input opposite to adjective"));
            string adjective_opposite = Console.ReadLine();
            string poem_new = poem.Replace(adjective, adjective_opposite);
            Console.WriteLine(poem_new);
        }

        public void Task_6()
        {
            Console.WriteLine("Write lowcase word:");
            string lowcase = Console.ReadLine();
            string convertedtoupper = lowcase.ToUpper();
            Console.WriteLine(convertedtoupper);
            
        }
    
}
}


