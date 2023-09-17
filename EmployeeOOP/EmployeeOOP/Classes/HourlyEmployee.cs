using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public int Hours { get; set; }
        public decimal HoursValue { get; set; }

        #endregion
        #region Methods

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HoursValue; //Multiply the number of hours by the value of the hours
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Cantidad de horas: {Hours}\n\t" +
                $"Valor por hora: {HoursValue:C2}\n\t"+
                $"Salario: {GetValueToPay():C2}\n\t"; ;


        }
        #endregion
    }
}
