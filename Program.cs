// See https://aka.ms/new-console-template for more information

using Kristina_Kulich__Application;

class Program
{
    static async Task Main(string[] args)
    {
     /*new Homework_1().Task_1();   
     new Homework_1().Task_2();*/
     //new Homework_1().Task_3();
     new Homework_1().Task_4();
     //new Homework_1().Task_6();
       /*string a = Console.ReadLine();
       string b = "Smith";
       var name = string.Format("Mr. {0} {1}", a, b);
        Console.WriteLine(name);*/
        

        /*var toconvert = Console.ReadLine();
        double convertedToToube = 0;
        double.TryParse(toconvert, out convertedToToube);
        var result = convertedToToube + 1;
        Console.WriteLine((result));*/
   
        await PrintAsync();   // вызов асинхронного метода
        Console.WriteLine("some action in method Main");
 
        void Print()
        {
            Thread.Sleep(3000);     // имитация продолжительной работы
            Console.WriteLine("Hello METANIT.COM");
        }
        
        async Task PrintAsync()
        {
            Console.WriteLine("start of method PrintAsync"); // выполняется синхронно
            await Task.Run(() => Print());                // выполняется асинхронно
            Console.WriteLine("end of method PrintAsync");
        }   

    }
}
