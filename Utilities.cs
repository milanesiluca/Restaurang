using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPiesShopHRM
{
    internal class Utilities
    {
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthWorked)
        {
            return monthlyWage * numberOfMonthWorked;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthWorked, int bonus)
        {
            return monthlyWage * numberOfMonthWorked + bonus;
        }

    }
}
