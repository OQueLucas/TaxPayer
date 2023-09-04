namespace Course.Entities {
  class Company : TaxPayer {
    public int EmployeeNumber {get;set;}

    public Company (string name, double annualIncome, int employeeNumber) : base (name, annualIncome) {
      EmployeeNumber = employeeNumber;
    }

    public override double Tax() {
      if (EmployeeNumber > 10) {
        return AnnualIncome * 0.14; 
      }
      return AnnualIncome * 0.16;
    }
  }
}