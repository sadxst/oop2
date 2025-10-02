using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ПР2_вар8
{
    internal class TCircle
    {
        private double radius;
        public TCircle()
        {
            radius = 0;
        }
        public TCircle(double r)
        {
            radius = r;
        }
        public TCircle(TCircle other)
        {
            radius = other.radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double AreaCircle()
        {
            return Math.PI * radius * radius;
        }
        public double AreaSector(double angle)
        {
            return (Math.PI * radius * radius * angle) / 360.0;
        }
        public double Length()
        {
            return 2 * Math.PI * radius;
        }
        public bool Compare(TCircle other)
        {
            return radius == other.radius;
        }
        public static TCircle operator +(TCircle a, TCircle b)
        {
            return new TCircle(a.radius + b.radius);
        }
        public static TCircle operator -(TCircle a, TCircle b)
        {
            return new TCircle(Math.Max(0, a.radius - b.radius));
        }
        public static TCircle operator *(TCircle a, double k)
        {
            return new TCircle(a.radius * k);
        }
        public static TCircle operator *(double k, TCircle a)
        {
            return new TCircle(a.radius * k);
        }
    }
}