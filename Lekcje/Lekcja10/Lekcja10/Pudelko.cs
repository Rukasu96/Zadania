using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja10
{
    public sealed class Pudelko : IFormattable, IEquatable<Pudelko> //sealed - nie mozna po tym dziedziczyc
    {
        private static readonly Dictionary<UnitOfMeasure, Dictionary<UnitOfMeasure, Func<double, double>>> converters = new()
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

        private readonly double a;
        private readonly double b;
        private readonly double c;
        private readonly UnitOfMeasure unitOfMeasure;

        public double A => Math.Round(Count(a, unitOfMeasure, UnitOfMeasure.meter), 3);

        public double B => Math.Round(Count(b, unitOfMeasure, UnitOfMeasure.meter), 3);

        public double C => Math.Round(Count(c, unitOfMeasure, UnitOfMeasure.meter), 3);

        public UnitOfMeasure UnitOfMeasure => unitOfMeasure;

        public double V => Math.Round(CountVolume(A,B,C),9);

        public double area => Math.Round(CountArea(A, B, C), 6);

        public List<double> edges;

        public Pudelko(double? a = null, double? b = null, double? c = null, UnitOfMeasure unitOfMeasure = UnitOfMeasure.meter)
        {
            if (a == null)
            {
                a = Count(10, UnitOfMeasure.centimeter, unitOfMeasure);
            }
            if (b == null)
            {
                b = Count(10, UnitOfMeasure.centimeter, unitOfMeasure);
            }
            if (c == null)
            {
                c = Count(10, UnitOfMeasure.centimeter, unitOfMeasure);
            }

            if(!IsCorrectValue(a.Value, unitOfMeasure) || !IsCorrectValue(b.Value, unitOfMeasure) || !IsCorrectValue(c.Value, unitOfMeasure))
            {
                throw new ArgumentException();
            }

            this.a = a.Value;
            this.b = b.Value;
            this.c = c.Value;
            this.unitOfMeasure = unitOfMeasure;
            edges = new List<double> {A, B, C};
        }

        private bool IsCorrectValue(double value, UnitOfMeasure unitOfMeasure)
        {
            double val = Count(value, unitOfMeasure, UnitOfMeasure.milimeter);
            return value > 0 && value <= 1000;
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

        public override string? ToString()
        {
            return $"{A:0.000} m × {B:0.000} m × {C:0.000} m";//\nPole: {area} m² Objętość: {V} m³";
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
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

            return A == other.a && B == other.b && C == other.c;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }

        public static Pudelko operator+(Pudelko p1, Pudelko p2)
        {
            return new Pudelko(p1.A + p2.A, p1.B + p2.B, p1.C + p2.C, UnitOfMeasure.meter);
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
