namespace EmployeeOOP.Classes
{
    class CommissionEmployee : Employee
    {
        #region Properties

        public double CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods
       
        public override decimal GetValueToPay()
        {
            return Sales * ((decimal)(CommissionPercentage / 100)); //Sales are multiplied with the commission percentage
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Porcentaje de comisión: {CommissionPercentage}%\n\t" +
                $"Ventas: {Sales:C2}\n\t";
               

        }
        #endregion
    }
}
