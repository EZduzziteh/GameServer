using System;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Game Server");
            Server.Start(12, 26950);

            Console.ReadKey();
        }
    }
}
