using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSecção2
{
    internal class Time
    {
        public int hh {  get; set; }
        public int mm {  get; set; }
        public int ss { get; set; }

        public Time() { }

        public Time(int hh, int mm, int ss)
        {
            this.hh = hh;
            this.mm = mm;
            this.ss = ss;
        }   
    }
}
