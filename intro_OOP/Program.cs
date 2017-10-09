using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //cat mittens = new cat();
            //mittens.Name = "Mittens";

            //cat secondCat = new cat("Oz", 3, "orange and white");
            //Console.WriteLine(mittens.Name);
            //Console.WriteLine(secondCat.Name);


            //mittens.Eat();

            //mittens.WorkOut(); 

            Dog firstDoge = new Dog();

            firstDoge.Weight = 60.00;
            firstDoge.Height = 3.2f;
            firstDoge.FurLength = "flowing mane";
            firstDoge.RunningSpeed = "will fetch.... eventually";

            firstDoge.Groom();
            Console.WriteLine(firstDoge.FurLength);

            firstDoge.Run();
            Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            Console.WriteLine(firstDoge.RunningSpeed);

            firstDoge.Bark(); 



           





        }
    }
}
