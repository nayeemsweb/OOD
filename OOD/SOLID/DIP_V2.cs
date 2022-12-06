using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class DIP_V2
    {
    }

    #region Rough

    public class SalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    }

    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
        public float GetSalary()
        {
            var salaryCalculator = new SalaryCalculator();
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
    #endregion

    #region Implementation

    //public interface ISalaryCalculator
    //{
    //    float CalculateSalary(int hoursWorked, float hourlyRate);
    //}

    //public class SalaryCalculator : ISalaryCalculator
    //{
    //    public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
    //}

    //public class EmployeeDetails
    //{
    //    private readonly ISalaryCalculator _salaryCalculator;
    //    public int HoursWorked { get; set; }
    //    public int HourlyRate { get; set; }
    //    public EmployeeDetails(ISalaryCalculator salaryCalculator)
    //    {
    //        _salaryCalculator = salaryCalculator;
    //    }
    //    public float GetSalary()
    //    {
    //        return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
    //    }
    //}
    #endregion
}
