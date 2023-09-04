namespace Course.Entities {
    class Individual : TaxPayer
   {
      public double HealthExpenses {get; set;}

      public Individual (string name, double annualIncome, double healthExpenses) : base (name, annualIncome) {
        HealthExpenses = healthExpenses;
        AnnualIncome = annualIncome;
      }

      public override double Tax() {
        if (AnnualIncome < 20000) {
          return AnnualIncome * 0.15 - HealthExpenses * 0.5;
        }
        
        return AnnualIncome * 0.25 - HealthExpenses * 0.5;
      }
    }
}