using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    class BaseCommissionEmployee : CommissionEmployee
    {

        #region Properties

        
        public decimal Base { get; set; }

        #endregion

        #region Methods

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;//Total commissions are added to the base salary.
        } 

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Salario base: {Base:C2}\n\t" + 
                   $"Salario Neto: {GetValueToPay():C2}\n\t";

        }
        #endregion
    }
}
