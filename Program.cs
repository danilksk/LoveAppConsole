using System;

namespace LoveAppConsole
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Console.Wri
            Console.Write("Введите число повторений ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сообщение ");
            string message = Convert.ToString(Console.ReadLine());
           
           for(int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i}.{message}", i);
            }
            
            
        }
    }
}
