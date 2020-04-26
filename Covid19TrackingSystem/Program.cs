using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19TrackingSystem
{
    class Program
    {
        //Conditions - 0:unknown, 1:no symptoms, 2: mild, 3: severe, 4: recovered, 5: dead
        //Locations -  0: home quarentine, 1: external quarentine, 2: hospital, 3: emergency care, 4: Cemetrery, 5: home (recovered)
        static void Main(string[] args)
        {
            Test1();
            Console.ReadLine();
        }
        public static void Test1()
        {
            Date today = new Date(31, 3, 2020);
            Covid19TrackingSystem cts = new Covid19TrackingSystem(today);
            cts.AddPatient("Moshe Cohen", 38, 1, 0);
            cts.AddPatient("Lea Levi", 23, 2, 2);
            cts.PrintAllPatients();
            Console.WriteLine(cts.ToString());

            if (cts.GetNumberOfPatients() == 2)
            {
                Console.WriteLine("Test1, Assertion1: Good");
            }
            else
            {
                Console.WriteLine("Test1, Assertion1: Fail. Expected number of patients: 2, actual: {0}", cts.GetNumberOfPatients());
            }

            today.Tomorrow();

            if (cts.NumberOfSickDays(0 , today) == 1)
            {
                Console.WriteLine("Test1, Assertion2: Good");
            }
            else
            {
                Console.WriteLine("Test1, Assertion2: Fail. Expected number of sick dyas for patients 0: 1, actual: {0}", cts.NumberOfSickDays(0, today));
            }
            today.Tomorrow();

            if (cts.NumberOfSickDays(1, today) == 2)
            {
                Console.WriteLine("Test1, Assertion3: Good");
            }
            else
            {
                Console.WriteLine("Test1, Assertion3: Fail. Expected number of sick dyas for patients 0: 2, actual: {0}", cts.NumberOfSickDays(1, today));
            }
        }
        

    }

    
}
