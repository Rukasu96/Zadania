using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeTimePeriod
{
    public struct Time : IEquatable<Time>, IComparable<Time>
    {
        private readonly byte hours;
        private readonly byte minutes;
        private readonly byte seconds;

        public Time(byte hours, byte minutes, byte seconds)
        {
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            {
                throw new ArgumentOutOfRangeException("Zła wartość");
            }

            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Time(byte hours, byte minutes) : this(hours, minutes, 0)
        {

        }

        public Time(byte hours) : this(hours, 0, 0)
        {

        }

        public Time(string s)
        {
            Regex regex = new Regex(@"^[0-2][0-4]|[0-1][0-9]:[0-5][0-9]:[0-5][0-9]$");
            MatchCollection matches = regex.Matches(s);

            this.hours = byte.Parse(matches[0].Value);
            this.minutes = byte.Parse(matches[1].Value);
            this.seconds = byte.Parse(matches[2].Value);
        }

        public byte Hours { get => hours; }
        public byte Minutes { get => minutes; }
        public byte Seconds { get => seconds; }

        public override string? ToString()
        {
            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }

        public bool Equals(Time other)
        {
            if (other == this)
            {
                return true;
            }
            if (other == null)
            {
                return false;
            }

            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }
        public override bool Equals(Object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Time t)
            {
                return Equals(t);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public int CompareTo(Time other)
        {
            int seconds = hours * 3600 + minutes * 60 + this.seconds;
            int secondsOther = other.hours * 3600 + other.minutes * 60 + other.seconds;
            return seconds.CompareTo(secondsOther);
        }

        public static Time operator +(Time t1, Time t2)
        {
            int hours = t1.hours + t2.hours;
            int minutes = t1.minutes + t2.minutes;
            int seconds = t1.seconds + t2.seconds;

            minutes += seconds / 60;
            seconds = seconds % 60;
            hours += minutes / 60;
            minutes = minutes % 60;
            hours = hours % 24;
            return new Time((byte)hours, (byte)minutes, (byte)seconds);
        }

        public static bool operator ==(Time? t1, Time? t2)
        {
            if (t1 is null && t2 is null)
            {
                return true;
            }
            if (t1 is null || t2 is null)
            {
                return false;
            }

            return t1.Value.Hours == t2.Value.Hours && t1.Value.Minutes == t2.Value.Minutes && t1.Value.Seconds == t2.Value.Seconds;

        }
        public static bool operator !=(Time? t1, Time? t2)
        {
            return !(t1 == t2);
        }
        public static bool operator <(Time t1, Time t2)
        {
            if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes)
            {
                return t1.Seconds < t2.Seconds;
            }
            if (t1.Hours == t2.Hours) 
            {
                return t1.Minutes < t2.Minutes;
            }

            return t1.Hours < t2.Hours;
        }
        public static bool operator <=(Time t1, Time t2)
        {
            if (t1.Hours == t2.Hours)
            {
                return t1.Minutes <= t2.Minutes;
            }
            if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes)
            {
                return t1.Seconds <= t2.Seconds;
            }

            return t1.Hours <= t2.Hours;
        }
        public static bool operator >(Time t1, Time t2)
        {
            return !(t1 <= t2);
        }
        public static bool operator >=(Time t1, Time t2)
        {
            return !(t1 < t2);
        }

        public static explicit operator byte[](Time t)
        {
            return new byte[] { t.Hours, t.Minutes, t.Seconds };
        }

        public static implicit operator Time((byte, byte, byte) value)
        {
            return new Time(value.Item1, value.Item2, value.Item3);
        }

    }

}
