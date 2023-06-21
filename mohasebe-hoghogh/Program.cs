using System;

namespace mohasebe_hoghogh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("meghdar hoghogh ra vared konid");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("meghdar hazine bime ra vared konid");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("darsad maliat ra vared konid");
            int c = Convert.ToInt32(Console.ReadLine());


            Class1 mahiane = new Class1();

            Console.WriteLine($"hoghogh khales shoma ={mahiane.hoghogh(a ,b , c)}");

            Console.ReadKey();

        }
    }
}
