using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootnallLeague
{
    public class Player
    {
        private const int MinimumAlloedYear = 1980;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private decimal salary;
        private Team team;
                
        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name should be at least 3 characters.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Last name should be at least 3 characters.");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary can't not be nagative");
                }

                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }

            set
            {
                if (value.Year < MinimumAlloedYear)
                {
                    throw new ArgumentException("Date of birth can't be earlier than " + MinimumAlloedYear);
                }

                this.dateOfBirth = value;
            }
        }

        public Team Team { get; set; }

        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            this.Salary = salary;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }
    }
}
