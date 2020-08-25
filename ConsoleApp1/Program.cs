using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            runDemo001();
            //runDemoCar();
        }

        static void runDemo001()
        {
            (new MyDemo.Demo001()).run();
        }

        static void runDemoCar()
        {
            (new MyDemo.DemoCar_Example()).run();
        }
    }
}
