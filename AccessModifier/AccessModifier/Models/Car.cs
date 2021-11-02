using System;

namespace AccessModifier.Models
{
    
    public class Car
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public double Engine { get; set; }
        protected string Color;
        private int _speed;
        //private readonly int _hp=20;
        //public readonly int _hp = 20;
        //public int _hp { get; }
        public int _hp { get; }
        public Car()
        {
            _hp = 200;
            Brand = "new Brand";
        }
        public Car(string brand,int hp)
        {
            _hp = hp;
            Brand = brand;
        }

        #region Encapsulation
        public int Speed
        {
            get
            {
                if (_speed != 0)
                {
                    return _speed;
                }
                return -1;
            }
            set
            {
                if (value >= 20)
                {
                    _speed = value;
                    return;
                }
                Console.WriteLine("Duzgun suret daxil etmediniz");
            }
        }
        //public void SetSpeed(int speed)
        //{
        //    if (speed >= 20)
        //    {
        //        _speed = speed;
        //        return;
        //    }
        //    Console.WriteLine("Duzgun suret daxil etmediniz");
        //}

        //public int GetSpeed()
        //{
        //    if (_speed != 0)
        //    {
        //        return _speed;
        //    }
        //    return -1;
        //}
        #endregion

        public void Run()
        {
            _speed = 100;
            Color = "red";
            Console.WriteLine(_hp);
        }
    }
}


