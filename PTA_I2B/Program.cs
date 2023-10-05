using PTA_I2B.BankovniUcty;

namespace PTA_I2B
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BankovniUcet BU = new BankovniUcet(900);
            Console.WriteLine($"{BU.Penize:c}");
            Console.ReadKey();
            BU.Vklad(20);
            Console.WriteLine($"{BU.Penize:c}");
            Console.ReadKey();
            BU.Vyber(919.9m);
            Console.WriteLine($"{BU.Penize:c}");


        }

    }

}