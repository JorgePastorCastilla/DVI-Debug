using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string w;
            int i, t, ttl;
            bool cont;
            List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
            TimeSheetEntry ent = new TimeSheetEntry();
            /* You have the do-while so you can avoid this first loop and just initiate the variables thare are gonna be use
             * 
            Console.Write("Enter what you did: ");
            w = Console.ReadLine();
            Console.Write("How long did you do it for: ");
            t = int.Parse(Console.ReadLine());
            TimeSheetEntry ent = new TimeSheetEntry();
            ent.HoursWorked = t;
            ent.WorkDone = w;
            ents.Add(ent);
            Console.Write("Do you want to enter more time:");
            bool cont = bool.Parse(Console.ReadLine());
            */
            do
            {
                Console.Write("Enter what you did: ");
                w = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                t = int.Parse(Console.ReadLine());
                ent = new TimeSheetEntry(); // YOU HAVE TO SET END TO A NEW OBJECT OR ELSE IT IS JUST ADDING THE SAME OBJECT TO THE LIST AND ITS CHANGING ITS VALUE EVERY TIME
                ent.HoursWorked = t;
                ent.WorkDone = w;
                ents.Add(ent);
                Console.Write("Do you want to enter more time:");

                // COMPARING IF YOU HAVE WRITE "YES" IF YOU HAVE DONE IT ITS TRUE IF NOT ITS FALSE
                cont = Console.ReadLine().ToUpper() == "YES"; 
            } while (cont == true);
            ttl = 0;
            for (i = 0; i < ents.Count; i++)
            {
                //if (ents[i].WorkDone.Contains("Acme"))
                // ADDING THIS LINE SO IT ALWAYS CHECK IF ACME ITS WRITEN WITHOUT BEING KEY SENSITIVE
                if (ents[i].WorkDone.ToUpper().Contains("ACME"))
                {
                    //ttl += i;
                    //ADDING hoursworked TO THE i VARIABLE CAUSE WHEN ITS THE FIRST ITERATION ITS VALUE IS 0 SO IF THE CONDITION
                    // IS TRUE YOU ARE DOING ttl =+ 0;
                    ttl += ents[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + ttl * 150 + " for the hours worked.");
            ttl = 0; //SETING tll TO 0 TO DONT CONFLICT WITH THE HOURS WORKED ON THE ABC LOOP
            for (i = 0; i < ents.Count; i++)
            {
                //if (ents[i].WorkDone.Contains("ABC"))
                // ADDING THIS LINE SO IT ALWAYS CHECK IF ABC ITS WRITEN WITHOUT BEING KEY SENSITIVE
                if (ents[i].WorkDone.ToUpper().Contains("ABC"))
                {
                    //ttl += i;
                    //ADDING hoursworked TO THE i VARIABLE CAUSE WHEN ITS THE FIRST ITERATION ITS VALUE IS 0 SO IF THE CONDITION
                    // IS TRUE YOU ARE DOING ttl =+ 0;
                    // ANOTHER SOLUTION COULD BE TO SET THE FOR LIKE THIS: (i = 1; i = ents.Count; i++)
                    ttl += ents[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + ttl * 125 + " for the hours worked.");

            ttl = 0; //SETING tll TO 0 TO DONT CONFLICT WITH THE LOOP
            for (i = 0; i < ents.Count; i++)
            {
                ttl += ents[i].HoursWorked;
            }
            if (ttl > 40)
            {
                Console.WriteLine("You will get paid $" + ttl * 15 + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + ttl * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public int HoursWorked;
    }
}
