using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class LSP
    {
    }

    #region Rough
    //public class VehicleV2
    //{
    //    public string? Color { get; set; }
    //    public virtual string? HelmetDesign { get; set; }
    //}

    //class MotorbikeV2 : VehicleV2
    //{
    //}

    //class CarV2 : VehicleV2
    //{
    //    //Violets LSP
    //    public override string? HelmetDesign => throw new NotImplementedException();
    //}

    #endregion

    #region Implementation
    public abstract class VehicleV2
    {
        public string? Color { get; set; }
    }

    public interface IHelmet
    {
        string HelmetDesign { get; set; }
    }

    class CarV2 : VehicleV2
    {
    }

    class MotorbikeV2 : VehicleV2, IHelmet
    {
        public string? HelmetDesign { get; set; }
    }
    #endregion
}
