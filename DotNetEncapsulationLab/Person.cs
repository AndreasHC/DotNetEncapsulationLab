namespace DotNetEncapsulationLab
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return age; } }
        public decimal Salary {  get { return salary; } }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:N2} dollars.";
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age < 30)
                percentage /= 2;
            this.salary = Math.Round(this.salary*(1+percentage/100), 2);
        }
    }
}
