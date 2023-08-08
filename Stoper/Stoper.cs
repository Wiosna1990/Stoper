using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stoper
{
    public class Stoper : StoperInterface
    {
        
        private DateTime startDate;
        private int stop;
        public void Display()
        {
            Console.WriteLine(stop + " Milisekund");

        }

        public void Reset()
        {
            stop = 0;
        }

        public void Start()
        {
            startDate = DateTime.Now;
        }

        public void Stop()
        {
            stop = (int)(DateTime.Now - startDate).TotalMilliseconds;
        }
    }
}
