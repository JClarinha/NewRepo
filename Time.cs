using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSecção2
{
    internal class Time
    {
        public TimeOnly dinner_time {  get; set; }

        public Time() { }

        public Time(TimeOnly dinner_time)
        {
            this.dinner_time = dinner_time;
        }  

        public TimeSpan TimeToDinner(TimeOnly now, TimeOnly dinner_time) {

            TimeSpan x = dinner_time - now;
        
            return x;
        }

        
    }
}
