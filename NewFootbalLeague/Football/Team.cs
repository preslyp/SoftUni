namespace Football
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    ////Teams have Name (string), Nickname (string), Date of Founding (datetime) and  a collection of Players
    ////Name and Nickname should be at least 5 characters long
    ////The collection of players cannot hold two identical players (where firstname and lastname match)

    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounted;

        public Team(string name, string nickname, DateTime dateFounted)
        {
            this.Name = name;
            this.NickName = nickname;
            this.DateFounted = dateFounted;
        }

        public Team Name
        {
            get
            {
                return this.Name;
            }

            set
            {
                if (this.name.Length < 5)
                {
                    throw new ArgumentException("Name must be at least 5 characters long!");
                }

                this.Name = value;
            }
        }

        public Team NickName
        {
            get
            {
                return this.NickName;
            }

            set
            {
                if (this.nickname.Length < 5)
                {
                    throw new ArgumentException("Name must be at least 5 characters long!");
                }

                this.NickName = value;
            }
        }

        public DateTime  DateFounted { get; set; }
    }
}
