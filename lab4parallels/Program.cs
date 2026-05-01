using lab4parallels;
using System;
namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new();
            for(int i = 0; i < 5; i++)
            {
                int id = i;
                new Thread(() => new Philosophers(id, table).Eat()).Start();
            }
        }
    }
}