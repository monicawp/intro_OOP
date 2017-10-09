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
            cat mittens = new cat();
            mittens.Name = "Mittens";

            cat secondCat = new cat("Oz", 3, "orange and white");
            Console.WriteLine(mittens.Name);
            Console.WriteLine(secondCat.Name);


            mittens.Eat();
            
            mittens.WorkOut(); 





        }
    }
}
