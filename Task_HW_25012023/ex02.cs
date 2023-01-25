using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_HW_25012023
{
    public class ex02
    {
        public Task<int> ShowNumbers()
        {
            int counter = 0;
            return Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    counter++;
                    Thread.Sleep(1000);
                }
                return counter;
            });
        }

    }
}
