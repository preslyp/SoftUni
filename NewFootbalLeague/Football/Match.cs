namespace Football
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    ////Matches have Home Team, Away Team, Score, and Id (int)
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam
        {
            get
            {
                return this.homeTeam;
            }

            set
            {
                if (this.awayTeam == this.homeTeam)
                {
                    throw new ArgumentException("The team' name can't be the same.");
                }

                this.homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get
            {
                return this.awayTeam;
            }

            set
            {
                if (this.awayTeam == this.homeTeam)
                {
                    throw new ArgumentException("The team' name can't be the same.");
                }

                this.awayTeam = value;
            }
        }

        public int Id { get; set; }

        public Score Score { get; set; }

        public Team GetWinner()
        {
            if (IsDraw())
            {
                return null;
            }
            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals ? this.HomeTeam : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            return this.Id.ToString() + " " + this.homeTeam.Name + " vs." + this.awayTeam.Name
                + " " + this.score.HomeTeamGoals + ":" + this.score.AwayTeamGoals;
        }
    }
}
