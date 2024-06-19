using System;

namespace Geometry
{ 
    public class HalfPlane
    {
        protected double a1, a2, b;
 
        public virtual void SetCoefficients(double a1, double a2, double b)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.b = b;
        }
         
        public virtual void DisplayCoefficients()
        {
            Console.WriteLine($"Півплощина: a1 = {a1}, a2 = {a2}, b = {b}");
        }
 
        public virtual bool IsPointInRegion(double x1, double x2, double x3 = 0)
        {
            return (a1 * x1 + a2 * x2 <= b);
        }
    }
 
    public class HalfSpace : HalfPlane
    {
        private double a3;
 
        public override void SetCoefficients(double a1, double a2, double b)
        {
            this.SetCoefficients(a1, a2, 0, b);  
        }
 
        public void SetCoefficients(double a1, double a2, double a3, double b)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.b = b;
        }
         
        public override void DisplayCoefficients()
        {
            Console.WriteLine($"Півпростір: a1 = {a1}, a2 = {a2}, a3 = {a3}, b = {b}");
        }
 
        public override bool IsPointInRegion(double x1, double x2, double x3)
        {
            return (a1 * x1 + a2 * x2 + a3 * x3 <= b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HalfPlane halfPlane = new HalfPlane();
            HalfPlane halfSpace = new HalfSpace();
 
            halfPlane.SetCoefficients(1, 2, 3);
            halfPlane.DisplayCoefficients();
            Console.WriteLine($"Точка (1, 1) в півплощині: {halfPlane.IsPointInRegion(1, 1)}");
 
            ((HalfSpace)halfSpace).SetCoefficients(1, 2, 4, 3);
            halfSpace.DisplayCoefficients();
            Console.WriteLine($"Точка (1, 1, 1) в півпросторі: {halfSpace.IsPointInRegion(1, 1, 1)}");
        }
    }
}