namespace Capitalisam.Models
{
    public abstract class PaidPerson : IPaidPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }
    }
}
