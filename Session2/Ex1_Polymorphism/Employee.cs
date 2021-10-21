namespace Ex1_Polymorphism
{
    public abstract class Employee
    {
        public string Name { get; set; }

        protected Employee(string name)
        {
            Name = name;
        }

        public virtual double GetMonthlySalary()
        {
            return 3.3;
        }
    }
}