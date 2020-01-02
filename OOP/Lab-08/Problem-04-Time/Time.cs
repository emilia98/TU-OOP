using System;

namespace Problem_04_Time
{
    public class Time
    {
        // field
        private int hour;

        // field
        private int minute;

        // field
        private int second;

        public int Hour
        {
            get { return this.hour; }
            set
            {
                if(value < 0 || value > 23)
                {
                    throw new FormatException("Hour should be between 0 and 23!");
                }

                this.hour = value;
            }
        }

        public int Minute
        {
            get { return this.minute; }
            set
            {
                if(value < 0 || value > 59)
                {
                    throw new FormatException("Minute should be between 0 and 59!");
                }

                this.minute = value;
            }
        }

        public int Second
        {
            get { return this.second; }
            set
            {
                if(value < 0 || value > 59)
                {
                    throw new FormatException("Second should be between 0 and 59!");
                }
                this.second = value;
            }
        }
    }
}
