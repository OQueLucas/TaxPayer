using System.Globalization;
using Course.Entities;

List <TaxPayer> list = new List <TaxPayer> ();
double totalTaxes = 0;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) {
  Console.WriteLine($"Tax payer #{i} data:");
  Console.Write("Individual or company (i/c)? ");
  char type = char.Parse(Console.ReadLine());
  System.Console.Write("Name: ");
  string name = Console.ReadLine();
  System.Console.Write("Anual income: ");
  double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  if (type == 'i') {
    Console.Write("Health expenditures: ");
    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add (new Individual(name, annualIncome, healthExpenditures));

  }
  else if (type == 'c') {
    Console.Write("Number of employees: ");
    int employeesNumber = int.Parse(Console.ReadLine());
    list.Add(new Company(name, annualIncome, employeesNumber));
  }
}

System.Console.WriteLine();
System.Console.WriteLine("TAXES PAID:");
foreach (TaxPayer taxPayer in list) {
  double tax = taxPayer.Tax();
  Console.WriteLine($"{taxPayer.Name}: ${tax.ToString("F2", CultureInfo.InvariantCulture)}");
  totalTaxes += tax;
}

System.Console.WriteLine();
System.Console.WriteLine($"TOTAL TAXES: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");