using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootnallLeague
{
    public class Score
    {
        private int awayTeamGoals;
        private int homeTeamGoals;

        public int AwayTeamGoals 
        {
            get { return this.awayTeamGoals; }
            set 
            {
                if (value <0)
                {
                    throw new ArgumentOutOfRangeException("Team gols can't not be anegative");
                }
                this.awayTeamGoals = value;
            } 
        }

        public int HomeTeamGoals
        {
            get { return this.homeTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Team gols can't not be anegative");
                }
                this.homeTeamGoals = value;
            } 
            
        }

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }
    }
}
