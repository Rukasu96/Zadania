using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lekcja10
{
    public sealed class Pudelko : IFormattable, IEquatable<Pudelko>, IEnumerable<double> //sealed - nie mozna po tym dziedziczyc
    {
        private static readonly IReadOnlyDictionary<UnitOfMeasure, Dictionary<UnitOfMeasure, Func<double, double>>> converters = new Dictionary< UnitOfMeasure, Dictionary<UnitOfMeasure, Func<double, double>>>()
        {
            { UnitOfMeasure.milimeter, new Dictionary<UnitOfMeasure, Func<double, double>>{
                { UnitOfMeasure.meter, x => x / 1000 },
                { UnitOfMeasure.centimeter, x => x /10 }
            }},
            { UnitOfMeasure.centimeter, new Dictionary<UnitOfMeasure, Func<double, double>>{
                { UnitOfMeasure.meter, x => x / 100 },
                { UnitOfMeasure.milimeter, x => x * 10 }
            }},
            { UnitOfMeasure.meter, new Dictionary<UnitOfMeasure, Func<double, double>>{
                { UnitOfMeasure.milimeter, x => x * 1000 },
                { UnitOfMeasure.centimeter, x => x * 100 }
            }},
        };

        public static readonly IReadOnlyDictionary<string, UnitOfMeasure> Units = new Dictionary<string, UnitOfMeasure>
        {
            { "m", UnitOfMeasure.meter},
            { "cm", UnitOfMeasure.centimeter},
            { "mm", UnitOfMeasure.milimeter},
        };

        private readonly double a;
        private readonly double b;
        private readonly double c;
        private readonly UnitOfMeasure unitOfMeasure;

        public double A => Math.Round(Count(a, unitOfMeasure, UnitOfMeasure.meter), 3);

        public double B => Math.Round(Count(b, unitOfMeasure, UnitOfMeasure.meter), 3);

        public double C => Math.Round(Count(c, unitOfMeasure, UnitOfMeasure.meter), 3);

        public UnitOfMeasure UnitOfMeasure => unitOfMeasure;

        public double V => Math.Round(CountVolume(A,B,C),9);

        public double Area => Math.Round(CountArea(A, B, C), 6);

        public List<double> edges;

        public Pudelko(double? a = null, double? b = null, double? c = null, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            if (a == null)
            {
                a = Count(10, UnitOfMeasure.centimeter, unit);
            }
            if (b == null)
            {
                b = Count(10, UnitOfMeasure.centimeter, unit);
            }
            if (c == null)
            {
                c = Count(10, UnitOfMeasure.centimeter, unit);
            }

            if(!IsCorrectValue(a.Value, unit) || !IsCorrectValue(b.Value, unit) || !IsCorrectValue(c.Value, unit))
            {
                throw new ArgumentException();
            }

            this.a = a.Value;
            this.b = b.Value;
            this.c = c.Value;
            this.unitOfMeasure = unit;
            edges = new List<double> {A, B, C};
        }

        private bool IsCorrectValue(double value, UnitOfMeasure unitOfMeasure)
        {
            double val = Count(value, unitOfMeasure, UnitOfMeasure.milimeter);
            return val > 0 && val <= 10000;
        }

        private double Count(double intValue, UnitOfMeasure inUnit, UnitOfMeasure outUnit)
        {
            if (inUnit == outUnit)
            {
                return intValue;
            }

            return converters[inUnit][outUnit](intValue);
        }

        private double CountVolume(double a, double b, double c)
        {
            return a * b * c;
        }

        private double CountArea(double a, double b, double c)
        {
            return 2 * a * b + 2 * a * c + 2 * b * c;
        }

        public static Pudelko Parse(string s)
        {
            if(!Regex.IsMatch(s, @"(\d+\.\d{3}\s[c|m]m?\s×\s){2}\d+\.\d{3}\s[c|m]m?"))
            {
                throw new FormatException();
            }

            Regex regex = new Regex(@"\d+\.\d{3}");
            MatchCollection Matches;
            Matches = regex.Matches(s);

            MatchCollection matches2 = new Regex(@"[c|m]m?").Matches(s);
            if (matches2[0].Value != matches2[1].Value || matches2[0].Value != matches2[2].Value)
            {
                throw new FormatException("Invalid unit of measure");
            }

            return new Pudelko(
                double.Parse(Matches[0].Value, CultureInfo.InvariantCulture), 
                double.Parse(Matches[1].Value, CultureInfo.InvariantCulture), 
                double.Parse(Matches[2].Value, CultureInfo.InvariantCulture),
                Pudelko.Units[matches2[0].Value]);
        }

        public override string? ToString()
        {
            return $"{A:0.000} m × {B:0.000} m × {C:0.000} m";//\nPole: {area} m² Objętość: {V} m³";
        }

        public string ToString(string? format, IFormatProvider? formatProvider=null)
        {
            switch(format)
            {
                case null:
                case "m":
                    return ToString();
                case "cm":
                    return $"{A * 100:0.0} cm × {B * 100:0.0} cm × {C * 100:0.0} cm";
                case "mm":
                    return $"{A * 1000:0} mm × {B * 1000:0} mm × {C * 1000:0} mm";
                default:
                    throw new FormatException();
            }
        }

        public bool Equals(Pudelko? other)
        {
            if(other == this)
            {
                return true;
            }
            if(other == null)
            {
                return false;
            }

            return A == other.A && B == other.B && C == other.C;

        }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(this == obj)
            {
                return true;
            }
            if(obj is Pudelko p)
            {
                return Equals(p);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }

        public IEnumerator<double> GetEnumerator()
        {
            yield return A;
            yield return B;
            yield return C;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Pudelko operator+(Pudelko p1, Pudelko p2)
        {
            return new Pudelko(p1.A + p2.A, p1.B + p2.B, p1.C + p2.C, UnitOfMeasure.meter);
        }

        public static bool operator==(Pudelko p1, Pudelko p2)
        {
            if (p1 is null && p2 is null)
            {
                return true;
            }
            if (p1 is null || p2 is null)
            {
                return false;
            }

            return p1.A == p2.A && p1.B == p2.B && p1.C == p2.C;
        }

        public static bool operator!=(Pudelko p1, Pudelko p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator double[](Pudelko p)
        {
            return new double[] { p.A, p.B, p.C };
        }

        public static implicit operator Pudelko((int, int, int) values)
        {
            return new Pudelko(values.Item1, values.Item2, values.Item3, UnitOfMeasure.milimeter);
        }

        public double this[int dim]
        {
            get
            {
                switch(dim)
                {
                    case 0:
                        return A;
                    case 1:
                        return B;
                    case 2:
                        return C;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
    }

    
}
