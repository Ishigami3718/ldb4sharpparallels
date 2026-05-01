using System;
using System.Collections.Generic;
using System.Text;

namespace lab4parallels
{
    public class Table
    {
        SemaphoreSlim[] forks = new SemaphoreSlim[5];
        public Table()
        {
            for (int i = 0; i < 5; i++)
            {
                forks[i] = new SemaphoreSlim(1, 1);
            }
        }

        public bool TryTakeFork(int id)
        {
            return forks[id].Wait(0);
        }
            public void TakeFork(int id)
            {
            forks[id].Wait();
        }
        public void PutFork(int id)
        {
            forks[id].Release();
        }
    }
}
