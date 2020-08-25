using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MyDemo
{
    class DemoCar
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead = false;

        public delegate void carHandler(string msg);
        private carHandler listOfHandlers;

        public DemoCar()
        {
            MaxSpeed = 100;
        }
        public DemoCar(string name, int maxSp, int currentSp)
        {
            CurrentSpeed = currentSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public void RegisterWithCarHandler(carHandler d)
        {
            //listOfHandlers = d;
            listOfHandlers += d;
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry, this car is dead ...");
                }
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == MaxSpeed - CurrentSpeed && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy ! Gonna blow!");
                }
            }

            if (CurrentSpeed >= MaxSpeed)
            {
                carIsDead = true;
            }
            else
            {
                carIsDead = false;
            }
        }

    }

    class DemoCar_Example
    {
        public void run()
        {
            Console.WriteLine(" ******** {0} ******** ", "init");

            DemoCar car = new DemoCar("dodo", 100, 10);
            car.RegisterWithCarHandler(OnCarEvent);
            car.RegisterWithCarHandler(OnCarEvent2);

            Console.WriteLine(" ******** {0} ******** ", "Accelerate");
            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine(" ******** 加速前 {0} ******** ", car.CurrentSpeed);
                car.Accelerate(20);
                Console.WriteLine(" ******** 加速後 {0} ******** ", car.CurrentSpeed);

                Console.ReadLine();
            }
            Console.ReadKey();
        }


        private void OnCarEvent(string msg)
        {
            Console.WriteLine($" ****** {msg} ******");
        }
        private void OnCarEvent2(string msg)
        {
            Console.WriteLine($" ### {msg} ###");
        }

    }
}
