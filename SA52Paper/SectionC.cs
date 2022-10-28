using System;
namespace SA52Paper
{
    public class Time12 
    {
        
        private int second;
        private int minute;
        private int hour;
        private bool isAM;

        public Time12(int s = 0,int m = 0,int h = 0, bool ma = true)
        {
            SetTime(h, m, s, ma);
        }

        public Time12(Time12 time) : this(time.Hour, time.Minute, time.Second) { }

        public void SetTime(int h,int m,int s,bool ma)
        {
            Hour = h;
            Minute = m;
            Second = s;
            IsAM = ma;
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    second = value;
                }
                else
                {
                    throw new InvalidSecondException();
                }
                
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else
                {
                    throw new InvalidMinuteException();
                }

                
            }
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public bool IsAM
        {
            get
            {
                return isAM;
            }
            set
            {
                isAM = value;
            }
        }

        public virtual void DisplayTime24()
        {
            int hour24;
            if (IsAM)
            {
                if (Hour == 12)
                    hour24 = 0;
                else
                    hour24 = Hour;
            }
            else
            {
                if (Hour == 12)
                    hour24 = Hour;
                else
                    hour24 = Hour + 12;
            }
            string hourStr = (hour24 < 10) ? "0" + hour24 : "" + hour24;
            string minuteStr = (Minute < 10) ? "0" + Minute : "" + Minute;
            string secondStr = (Second < 10) ? "0" + Second : "" + Second;
            Console.WriteLine("{0}:{1}:{2}",hourStr,minuteStr,secondStr);
        }

        public override string ToString()
        {
            
            return String.Format(
                "{0} hour(s),{1} minute(s),{2} second(s), {3}"
                ,Hour,Minute,Second,(
                IsAM?"AM":"PM"));
        }

    }

    public class InvalidSecondException : Exception
    {
        public InvalidSecondException():base("The second is invalid.") { }
        public InvalidSecondException(string messageValue) : base(messageValue) { }
        public InvalidSecondException(string messageValue, Exception inner) : base(messageValue, inner) { }
    }

    public class InvalidMinuteException : Exception
    {
        public InvalidMinuteException() : base("The second is invalid.") { }
        public InvalidMinuteException(string messageValue) : base(messageValue) { }
        public InvalidMinuteException(string messageValue, Exception inner) : base(messageValue, inner) { }
    }

    public class InvalidTimeZoneException:Exception
    {
        public InvalidTimeZoneException() : base("The timezone is invalid.") { }
    }

    public class Time12TZ : Time12
    {
        private int timezone;
        public Time12TZ(int s =0,int m=0 ,int h=0 ,bool ma=true ,int t=0) : base(s, m, h, ma)
        {
            Timezone = t;
        }

        public int Timezone
        {
            get
            {
                return timezone;
            }
            set
            {
                if (value >= -12 && value <= 14)
                {
                    timezone = value;
                }
                else
                {
                    throw new InvalidTimeZoneException();
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{4} timezone, {0} hour(s),{1} minute(s),{2} second(s), {3}"
                , Hour, Minute, Second, (
                IsAM ? "AM" : "PM"),Timezone);
        }

        public override void DisplayTime24()
        {
            base.DisplayTime24();
            Console.WriteLine("{0}{1}{2}", (Timezone == 0 ? "GMT" : "UTC"), (Timezone > 0 ? "+":""),Timezone);
        }
    }


}

