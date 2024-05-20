using BethanysPiesShopHRM;

int amount = 1234;
int months = 12;

var amonth = Utilities.CalculateYearlyWage(amount, months);
var amountWithBonus = Utilities.CalculateYearlyWage(amount, months, 1000);
Console.WriteLine($"Yearly Wage: {amonth}");
Console.WriteLine($"Yearly Wage with Bonus: {amountWithBonus}");
Console.WriteLine("cIAO");

