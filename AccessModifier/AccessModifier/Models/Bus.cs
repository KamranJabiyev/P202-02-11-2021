using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Models
{
    class Bus:Car
    {
        public int PassengerCount;
        public void Test()
        {
            Run();
            Model = "H1";
            Color = "White";
            Brand = "sasfsdf";
            //Console.WriteLine(_hp);
        }
    }
}
