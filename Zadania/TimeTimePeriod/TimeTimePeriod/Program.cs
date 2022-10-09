using System.Text.RegularExpressions;

public struct Time: IEquatable<Time>, IComparable<Time>
{
    private byte hours;
    private byte minutes;
    private byte seconds;

    public Time(byte hours, byte minutes, byte seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }
    public Time(byte hours, byte minutes)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = 0;
    }
    public Time(byte hours)
    {
        this.hours = hours;
        this.minutes = 0;
        this.seconds = 0;
    }
    public Time(string s)
    {
        Regex regex = new Regex("[0-60]");
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
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (this == obj)
        {
            return true;
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

    public static bool operator ==(Time t1, Time t2)
    {
        return t1 == t2;
    }
    public static bool operator !=(Time t1, Time t2)
    {
        return t1 != t2;
    }
    public static bool operator <(Time t1, Time t2)
    {
        return t1 < t2;
    }
    public static bool operator <=(Time t1, Time t2)
    {
        return t1 <= t2;
    }
    public static bool operator >(Time t1, Time t2)
    {
        return t1 > t2;
    }
    public static bool operator >=(Time t1, Time t2)
    {
        return t1 >= t2;
    }

    public static explicit operator byte[](Time t)
    {
        return new byte[] { t.Hours, t.Minutes, t.Seconds };
    }

    public static implicit operator Time((byte, byte, byte) values)
    {
        return new Time(values.Item1, values.Item2, values.Item3);
    }

}
