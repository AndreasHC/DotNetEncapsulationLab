namespace DotNetEncapsulationLab
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value.Length < 3)
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                age = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            private set
            {
                if (value < 460)
                    throw new ArgumentException("Salary cannot be less than 460 dollar!");
                salary = value;
            }
        }



        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:N2} dollars.";
        }
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age < 30)
                percentage /= 2;
            Salary = Math.Round(this.salary * (1 + percentage / 100), 2);
        }
    }
}
