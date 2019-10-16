using System;

namespace TemperatureSerra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quale è la temperatura nella serra");
            int t = int.Parse(Console.ReadLine());
            if(t==18 && t>18)
            {
                Console.WriteLine("la temperatura è normale");
            }
            if(t<5)
            {
                Console.WriteLine("la temperatura provoca danni irreparabili");
            }
            if(t>=5 && t<=18)
            {
                Console.WriteLine("la temperatura è pericolosa");
            }
            

        }
    }
}
