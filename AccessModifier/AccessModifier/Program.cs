using AccessModifier.Models;
using AccessModifier.Models.DemoNS;
using System;
using System.Reflection;

namespace AccessModifier
{
    partial class Car
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Public - class(interface), all class members(field,method,property)
            //Car car = new Car();
            //car.Brend = "BMW";
            //Console.WriteLine(car.Brend);
            //car.Run();
            #endregion

            #region Protected-all class members
            //Car car = new Car();
            #endregion

            #region Private - all class members
            //Car car = new Car();
            //typeof(Car).GetField("_speed", BindingFlags.NonPublic | BindingFlags.Instance)
            //    .SetValue(car, 300);
            //var speed = typeof(Car).GetField("_speed", BindingFlags.NonPublic | BindingFlags.Instance)
            //    .GetValue(car);
            //Console.WriteLine(speed);
            //car.Run();
            #endregion

            #region Encapsulation
            //Car car = new Car();
            //car.SetSpeed(50);
            //Console.WriteLine(car.GetSpeed());
            //car.Speed = 300;
            //Console.WriteLine(car.Speed);
            //Car car1 = new Car("Mercedes");
            //Console.WriteLine(car1.Brand);
            #endregion

            #region readonly - field

            Models.DemoNS.Car car = new Models.DemoNS.Car();

            //Car car1 = new Car();
            
            //Console.WriteLine(car._hp);
            #endregion

        }
    }

    //class Car
    //{
    //    public int MyProperty { get; set; }
    //}

    
}
