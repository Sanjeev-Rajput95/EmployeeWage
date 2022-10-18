using System;
using EmployeeWage;

namespace EmployeeWage
{
    class program
    {


        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage ("DMART ", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage ("Relience ", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        
        }
    }
}