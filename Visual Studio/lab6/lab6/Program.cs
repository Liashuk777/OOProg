using System;

namespace Geometry
{ 
    public abstract class Region
    { 
        protected double a1, a2, b;
 
        public abstract void SetCoefficients(double a1, double a2, double b, double a3 = 0);
 
        public abstract void DisplayCoefficients();
 
        public abstract bool IsPointInRegion(double x1, double x2, double x3 = 0);
 
        public Region()
        {
            Console.WriteLine("Конструктор класу Region викликаний");
        }
 
        ~Region()
        {
            Console.WriteLine("Деструктор класу Region викликаний");
        }
    }
 
    public class HalfPlane : Region
    { 
        public override void SetCoefficients(double a1, double a2, double b, double a3 = 0)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.b = b;
        }
 
        public override void DisplayCoefficients()
        {
            Console.WriteLine($"Півплощина: a1 = {a1}, a2 = {a2}, b = {b}");
        }
 
        public override bool IsPointInRegion(double x1, double x2, double x3 = 0)
        {
            return (a1 * x1 + a2 * x2 <= b);
        }
 
        public HalfPlane() : base()
        {
            Console.WriteLine("Конструктор класу HalfPlane викликаний");
        }
 
        ~HalfPlane()
        {
            Console.WriteLine("Деструктор класу HalfPlane викликаний");
        }
    }
 
    public class HalfSpace : HalfPlane
    {
        private double a3;
 
        public override void SetCoefficients(double a1, double a2, double b, double a3 = 0)
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
 
        public HalfSpace() : base()
        {
            Console.WriteLine("Конструктор класу HalfSpace викликаний");
        }
 
        ~HalfSpace()
        {
            Console.WriteLine("Деструктор класу HalfSpace викликаний");
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            Region halfPlane = new HalfPlane();
            Region halfSpace = new HalfSpace();
 
            halfPlane.SetCoefficients(1, 2, 3);
            halfPlane.DisplayCoefficients();
            Console.WriteLine($"Точка (1, 1) в півплощині: {halfPlane.IsPointInRegion(1, 1)}");
 
            halfSpace.SetCoefficients(1, 2, 4, 3);
            halfSpace.DisplayCoefficients();
            Console.WriteLine($"Точка (1, 1, 1) в півпросторі: {halfSpace.IsPointInRegion(1, 1, 1)}");
        }
    }
}