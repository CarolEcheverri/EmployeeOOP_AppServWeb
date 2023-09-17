using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year;
    string firstName, lastName;
    decimal salary, sales, baseS, hoursValue;
    double commissionPercentage;
    int hours; 
 


    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");


    //Class Date

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    
    Date dateObject = new Date(day, month, year);

    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());
    Console.WriteLine("\n");

    //Class Employee and SalaryEmployee

    Console.Write("Ingresar nombre:\n ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos:\n ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar Salario devengado:\n ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };

    Console.WriteLine(salaryEmployee + "\n");

    //Clase CommissionEmployee

    Console.Write("Ingresar porcentaje de comisión:\n ");
    commissionPercentage = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingresar valor de las ventas:\n ");
    sales = Decimal.Parse(Console.ReadLine());

    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentage= commissionPercentage,
        Sales = sales,

    }; 
    Console.WriteLine(commissionEmployee + "\n");


    //Clase BaseCommissionEmployee

    Console.Write("Ingresar salario base: \n");
    baseS = Decimal.Parse(Console.ReadLine());

    BaseCommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee() {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentage = commissionPercentage,
        Sales = sales,
        Base = baseS,
    };

    Console.WriteLine(baseCommissionEmployee + "\n");


    //Clase HourlyEmployee

    Console.Write("Ingresar cantidad de horas: \n");
    hours = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar valor por hora: \n");
    hoursValue = Decimal.Parse(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = hours,
        HoursValue = hoursValue,
    };

    Console.WriteLine(hourlyEmployee + "\n");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}