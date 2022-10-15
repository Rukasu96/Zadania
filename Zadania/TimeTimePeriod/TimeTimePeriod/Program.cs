using System.Text.RegularExpressions;

public struct Time: IEquatable<Time>, IComparable<Time>
{
    private byte hours;
    private byte minutes;
    private byte seconds;

    public Time(byte hours, byte minutes, byte seconds)
    {
        if(hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
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

    public byte Hours { get => hours; set => hours = value; }
    public byte Minutes { get => minutes; set => minutes = value; }
    public byte Seconds { get => seconds; set => seconds = value; }

    public override string? ToString()
    {
        return $"{hours}:{minutes}:{seconds}";
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
        throw new NotImplementedException();
    }

    public static Time operator +(Time t1, Time t2)
    {
        return new Time((byte)(t1.Hours + t2.Hours),(byte)(t1.Minutes + t2.Minutes), (byte)(t1.Seconds + t2.Seconds));
    }

    public static bool operator ==(Time? t1, Time? t2)
    {
        if(t1 is null && t2 is null)
        {
            return true;
        }
        if(t1 is null || t2 is null)
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
        if(t1.Hours == t2.Hours)
        {
            return t1.Minutes < t2.Minutes;
        }
        if(t1.Hours == t2.Hours && t1.Minutes == t2.Minutes)
        {
            return t1.Seconds < t2.Seconds;
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
        return !(t1 < t2);
    }
    public static bool operator >=(Time t1, Time t2)
    {
        return !(t1 <= t2);
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



public struct TimePeriod : IEquatable<TimePeriod>, IComparable<TimePeriod>
{
    private long seconds;

    public TimePeriod(int hours, byte minutes, byte seconds)
    {
        if(hours < 0 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
        {
            throw new ArgumentOutOfRangeException("Zła wartość");
        }

        this.seconds = hours * 3600 + minutes * 60 + seconds;
    }

    public TimePeriod(int hours, byte minutes) : this(hours, minutes, 0)
    {

    }

    public TimePeriod(long seconds)
    {
        this.seconds = seconds;
    }

    public TimePeriod(Time t1, Time t2)
    {
        int hours = t1.Hours - t2.Hours;
        int minutes = t1.Minutes - t2.Minutes;
        int seconds = t1.Seconds - t2.Seconds;

        if (hours < 0)
        {
            hours *= -1;
        }
        if (minutes < 0)
        {
            minutes *= -1;
        }
        if (seconds < 0)
        {
            seconds *= -1;
        }

        this.seconds = hours * 3600 + minutes * 60 + seconds;
    }

    public TimePeriod(string s)
    {
        Regex regex = new Regex(@"\d+:[0-5][0-9]:[0-5][0-9]$");
        MatchCollection matches = regex.Matches(s);

        int hours = byte.Parse(matches[0].Value);
        byte minutes = byte.Parse(matches[1].Value);
        byte seconds = byte.Parse(matches[2].Value);

        this.seconds = hours * 3600 + minutes * 60 + seconds;
    }

    public TimePeriod TimePeriodPlus(TimePeriod tp)
    {
        seconds += tp.seconds;

        long hours = seconds % 3600;
        long minutes = (hours * 3600 - seconds) % 60;
        seconds -= hours * 3600 + minutes * 60;

        return new TimePeriod((int)hours,(byte)minutes,(byte)seconds);
    }

    public TimePeriod TimePeriodMinus(TimePeriod tp)
    {
        seconds -= tp.seconds;

        if(seconds < 0)
        {
            seconds *= -1;
        }

        long hours = seconds % 3600;
        long minutes = (hours * 3600 - seconds) % 60;
        seconds -= hours * 3600 + minutes * 60;

        return new TimePeriod((int)hours, (byte)minutes, (byte)seconds);
    }

    public static TimePeriod TimePeriodPlus(TimePeriod tp1, TimePeriod tp2)
    {
        long seconds = tp1.seconds + tp2.seconds;

        long hours = seconds % 3600;
        long minutes = (hours * 3600 - seconds) % 60;
        seconds -= hours * 3600 + minutes * 60;

        return new TimePeriod((int)hours, (byte)minutes, (byte)seconds);
    }

    public static TimePeriod TimePeriodMinus(TimePeriod tp1, TimePeriod tp2)
    {
        long seconds = tp1.seconds - tp2.seconds;

        if(seconds < 0)
        {
            seconds *= -1;
        }

        long hours = seconds % 3600;
        long minutes = (hours * 3600 - seconds) % 60;
        seconds -= hours * 3600 + minutes * 60;

        return new TimePeriod((int)hours, (byte)minutes, (byte)seconds);
    }


    public override string? ToString()
    {
        long hours = seconds % 3600;
        long minutes = (hours * 3600 - seconds)%60;
        seconds -= hours * 3600 + minutes * 60;

        return $"{hours}:{minutes}:{seconds}";
    }

    public bool Equals(TimePeriod other)
    {
        if (other == this)
        {
            return true;
        }

        return seconds == other.seconds;
    }

    public int CompareTo(TimePeriod other)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(Object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (obj is TimePeriod tp)
        {
            return Equals(tp);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(seconds);
    }

    public static TimePeriod operator +(TimePeriod tp1, TimePeriod tp2)
    {
        return new TimePeriod((tp1.seconds + tp2.seconds));
    }

    public static bool operator ==(TimePeriod? tp1, TimePeriod? tp2)
    {
        if (tp1 is null && tp2 is null)
        {
            return true;
        }
        if (tp1 is null || tp2 is null)
        {
            return false;
        }

        return tp1.Value.seconds == tp2.Value.seconds;

    }
    public static bool operator !=(TimePeriod? tp1, TimePeriod? tp2)
    {
        return !(tp1 == tp2);
    }
    public static bool operator <(TimePeriod tp1, TimePeriod tp2)
    {
        return tp1.seconds < tp2.seconds;
    }
    public static bool operator <=(TimePeriod tp1, TimePeriod tp2)
    {
        return tp1.seconds <= tp2.seconds;
    }
    public static bool operator >(TimePeriod tp1, TimePeriod tp2)
    {
        return !(tp1 < tp2);
    }
    public static bool operator >=(TimePeriod tp1, TimePeriod tp2)
    {
        return !(tp1 <= tp2);
    }

    public static explicit operator long[](TimePeriod tp)
    {
        return new long[] { tp.seconds};
    }

    public static implicit operator TimePeriod((long,long) value)
    {
        return new TimePeriod(value.Item1);
    }
}
