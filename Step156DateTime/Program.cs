
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Step156DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please provide a whole number: ");
            string userInput = Console.ReadLine();
            int userInt = Convert.ToInt32(userInput);

            //get current time
            DateTime nowTime = DateTime.Now;

            TimeSpan xHours = new TimeSpan(userInt, 0, 0);



            DateTime timeLater = nowTime + xHours;
            Console.WriteLine("It will be "+timeLater+" in "+userInt+" hours. The number you provided.");
        }
    }
}
