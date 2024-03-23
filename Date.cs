using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSecção2
{
    internal class Date
    {
        public int d {  get; set; } 
        public int m { get; set; }
        public int a { get; set; }

        public Date() { }

        public Date(int d, int m, int a)
        {
            this.d = d;
            this.m = m;
            this.a = a;
        }   

        public int Age(int BirthDay, int BirthMonth, int BirthYear, int CurrentDay, int CurrentMonth, int CurrentYear)
        {
            int age;
            if ((BirthMonth > CurrentMonth && BirthDay > CurrentDay)) 
            {
                age = (CurrentYear - 1) - BirthYear;
         
            }

            else 
            {
                age = CurrentYear - BirthYear;
            }

            return age;
        }

    }
}
