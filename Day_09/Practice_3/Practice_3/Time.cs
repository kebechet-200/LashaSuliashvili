using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_3
{
    class Time
    {
        public int Second { get; set; }
        public int Minute { get; set; }
        public int Hour { get; set; }

        private void SubSecond()
        {
            if (Second != 0)
                Second--;
        }

        private void SubMinute()
        {
            if (Minute != 0)
                Minute--;
        }

        private void SubHour()
        {
            if(Hour != 0)
                Hour--;
        }
        
        public void AddSecond()
        {
            if(Second < 59)
                Second++;
            else
            {
                Second = 0;
                if(Minute < 59)
                    Minute++;
                else
                {
                    Minute = 0;
                    if (Hour < 23)
                        Hour++;
                    else Hour = 0;
                }
            }

        }

        public void AddMinute()
        {
            if(Minute < 59)
                Minute++;
            else
            {
                Minute = 0;
                if (Hour < 23) Hour++;
                else Hour = 0;
            }
        }

        public void AddHour()
        {
            if (Hour < 23) Hour++;
            else Hour = 0;
        }
    }
}
