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
    //public class Animal
    //{
    //    public string Color { get; set; }
    //    public virtual bool IsReptile { get; set; }
    //}

    //class Tiger : Animal
    //{
    //    //Violets LSP
    //    public override bool IsReptile => throw new NotImplementedException();
    //}

    //class Crocodile : Animal
    //{        
    //}
    #endregion

    #region Implementation
    public abstract class Animal
    {
        public string Color { get; set; }
    }

    interface IReptile
    {
        bool IsReptile { get; set; }
    }

    class Tiger : Animal
    {
    }

    class Crocodile : Animal, IReptile
    {
        public bool IsReptile { get; set; }
    }
    #endregion
}
