using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class ISP
    {
    }

    #region Rough
    public interface ITeam
    {
        public int BallCount { get; set; }
        public int WicketCount { get; set; }
    }

    public class CricketTeam : ITeam
    {
        public string Name { get; set; }
        public int BallCount { get; set; }
        public int WicketCount { get; set; }
    }

    public class PoolTeam : ITeam
    {
        public string Name { get; set; }
        public int BallCount { get; set; }
        public int WicketCount { get; set; } //Violets ISP
    }
    #endregion

    #region Implementation
    //public interface ITeam
    //{
    //    public int BallCount { get; set; }
    //}

    //public interface IWicket
    //{
    //    public int WicketCount { get; set; }
    //}

    //public class CricketTeam : ITeam, IWicket
    //{
    //    public string Name { get; set; }
    //    public int BallCount { get; set; }
    //    public int WicketCount { get; set; }
    //}

    //public class PoolTeam : ITeam
    //{
    //    public string Name { get; set; }
    //    public int BallCount { get; set; }
    //}
    #endregion
}
