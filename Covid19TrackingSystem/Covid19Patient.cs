using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19TrackingSystem
{
    class Covid19Patient
    {
        int id;
        string name;
        double age;
        Date contractingDate;
        int condition;       //0:unknown, 1:no symptoms, 2: mild, 3: severe, 4: recovered, 5: dead
        int location;       // 0: home quarentine, 1: external quarentine, 2: hospital, 3: emergency care, 4: Cemetrery, 5: home (recovered)


        public Covid19Patient(int id , string name , double age, Date today , int cond , int loc)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.contractingDate = new Date(today);
            this.condition = cond;
            this.location = loc;
        }

        public Covid19Patient(int id, string name, double age, Date today)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.contractingDate = new Date(today);
            this.condition = 0;
            this.location = 0;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        
        public int GetId()
        {
            return this.id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }


        public void SetContractingDate(Date d)
        {
            this.contractingDate.SetDay(d.GetDay());
            this.contractingDate.SetMonth(d.GetMonth());
            this.contractingDate.SetYear(d.GetYear());
        }

        public Date GetContractingDate()
        {
            return this.contractingDate;
        }

        public void SetCondition(int cond)
        {
            this.condition = cond;
        }

        public int GetCondition()
        {
            return this.condition;
        }

        public void SetLocation(int loc)
        {
            this.location = loc;
        }

        public int GetLocation()
        {
            return this.location;
        }

        public override string ToString()
        {
            return "Patient " + this.id + " , " + this.name + " , sick since " + this.contractingDate.ToString();
        }

        public int NumberOfSickDays(Date d)
        {
            return this.contractingDate.DaysDifference(d);
        }
    }


}
