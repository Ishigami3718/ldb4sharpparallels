using System;
using System.Collections.Generic;
using System.Text;

namespace lab4parallels
{
    public class Philosophers
    {
        int id,
            leftFork,
            rightFork;

        Table table;

        public int Id { get => id; }
        public int LeftFork { get => leftFork; }
        public int RightFork { get => rightFork; }

        public Philosophers(int id, Table table)
        {
            this.id = id;
            //this.leftFork = (id + 1) % 5;
            //this.rightFork = id;
            
            this.leftFork =id ==4 ? id : (id + 1) % 5;
            this.rightFork = id ==4?(id + 1) % 5:id;
           
            this.table = table;
        }

        public void Eat()
        {
            for (int i = 0; i < 10; i++)
            {
                
                  Console.WriteLine($"Philosopher {id} is thinking");
                table.TakeFork(rightFork);
                table.TakeFork(leftFork);
                  Console.WriteLine($"Philosopher {id} is eating");
                        table.PutFork(rightFork);
                        table.PutFork(leftFork);
                 

                //Console.WriteLine($"Philosopher {id} is thinking {i+1} times");
                //table.TakeFork(rightFork);
                //if (table.TryTakeFork(leftFork))
                //{
                //    Console.WriteLine($"Philosopher {id} is eating {i + 1} times");
                //    table.PutFork(rightFork);
                //    table.PutFork(leftFork);
                //}
                //else
                //{
                //    table.PutFork(rightFork);
                //}
            }
        }

    }
}
