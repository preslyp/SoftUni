using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootnallLeague
{
    public class Team
    {
        private const int minDateFonded = 1950;
        private string name;
        private string nickname;
        private DateTime dateFonded;
        private List<Player> players;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.NickName = nickname;
            this.DateFonded = dateFonded;
            this.players = new List<Player>();
        }

        public string Name 
        {
            get 
            { 
                return this.name; 
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("The name shoud be more then 5 characters.");
                }
                this.name = value;
            }
        }

        public string NickName
        {
            get { return this.nickname; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("The nickname shoud be more then 5 characters.");
                }
                this.nickname = value;
            }
        }

        public DateTime DateFonded
        {
            get { return this.dateFonded; }
            set
            {
                if (value.Year < minDateFonded)
                {
                    throw new ArgumentException("Date of founded can't be earlier than " + minDateFonded);
                }
                this.dateFonded = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIsPlayerExists(player))
            {
                throw new InvalidOperationException("Playes already exist for that team.");
            }
            this.players.Add(player);
        }


        private bool CheckIsPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }
    }
}
