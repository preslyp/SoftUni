namespace Capitalisam.Models
{
    public class Employee : PaidPerson,     
    {
        public Department Department { get; set; }

        public double SalaryFactor { get; set; }
    }
}
