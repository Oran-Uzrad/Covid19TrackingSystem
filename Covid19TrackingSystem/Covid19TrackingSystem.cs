using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19TrackingSystem
{
    class Covid19TrackingSystem
    {
        Date currentDate;
        Covid19Patient[] p;
        int numberOfPatients;

        public Covid19TrackingSystem(Date d)
        {
            this.currentDate = new Date(d);
            this.p = new Covid19Patient[100];
            this.numberOfPatients = 0;
        }

        public int GetNumberOfPatients()
        {
            return this.numberOfPatients;
        }

        public override string ToString()
        {
            return "Covid19TrackingSystem " + this.currentDate.ToString() + " " + this.numberOfPatients + " patients";
        }

        public void nextDay()
        {
            this.currentDate.Tomorrow();
        }

        public int AddPatient(string name , int age , int cond , int loc)
        {
            if (this.numberOfPatients >= 99)
            {
                return -1;
            }
            else
            {
                p[this.numberOfPatients] = new Covid19Patient(numberOfPatients, name, age, this.currentDate, cond, loc);
                this.numberOfPatients++;
                return(this.numberOfPatients - 1);
            }
        }

        public void UpdateCondition(int id , int cond)
        {
            this.p[id].SetCondition(cond);
        }

        public int numberOfCondition(int cond)
        {
            int count = 0; 
            for (int i = 0; i < numberOfPatients; i++)
            {
                if (p[i].GetCondition() == cond)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintAllCondition(int cond)
        {
            for (int i = 0; i < numberOfPatients; i++)
            {
                if (p[i].GetCondition() == cond)
                {
                    Console.WriteLine(p[i].ToString());
                }
            }
        }

        public void PrintAllPatients()
        {
            for (int i = 0; i < numberOfPatients; i++)
            {
                Console.WriteLine(p[i].ToString());
            }

        }

        public int NumberOfSickDays(int id , Date d)
        {
            return p[id].NumberOfSickDays(d);
        }
    }
}
