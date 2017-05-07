using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootnallLeague
{
    public class Matche
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Matche(Team homeTeam, Team awayTeam, Score score, int id )
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score =score;
            this.ID = id;
        }

        public Team HomeTeam
        {
            get { return this.homeTeam; }
            set 
            {
                this.homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get { return this.awayTeam; }
            set 
            {
                if (this.homeTeam.Equals(value.Name))
                {
                    throw new ArgumentException("The names of the teams in a match cannot be the same!");
                }
                this.awayTeam = value; 
            }
        }

        public Score Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals ? this.HomeTeam : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }
    }
}
