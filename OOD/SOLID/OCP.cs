using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class OCP
    {
    }

    #region Rough  
    //public class Car
    //{
    //    public int Wheels { get; set; }
    //}

    //public class Motorbike
    //{
    //    public int Wheels { get; set; }
    //}

    //public class Wheel
    //{
    //    public int CountTotalWheels(object[] vehicles)
    //    {
    //        var wheelCount = 0;

    //        foreach (var vehicle in vehicles)
    //        {
    //            if (vehicle is Car)
    //                wheelCount += ((Car)vehicle).Wheels;

    //            if (vehicle is Motorbike)
    //                wheelCount += ((Motorbike)vehicle).Wheels;
    //        }
    //        return wheelCount;
    //    }
    //}

    #endregion

    #region Implementation
    public abstract class Vehicle
    {
        public int Wheels { get; set; }
    }
    public class Car : Vehicle
    {
    }

    public class Motorbike : Vehicle
    {
    }

    public class Wheel
    {
        public int CountTotalWheels(Vehicle[] vehicles)
        {
            var wheelCount = 0;

            foreach (var vehicle in vehicles)
            {
                wheelCount += vehicle.Wheels;
            }
            return wheelCount;
        }
    }

    #endregion
}
