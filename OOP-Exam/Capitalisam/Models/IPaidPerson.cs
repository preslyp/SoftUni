namespace Capitalisam.Models
{
    public interface IPaidPerson : IPerson
    {
        decimal Salary { get; set; }
    }
}
