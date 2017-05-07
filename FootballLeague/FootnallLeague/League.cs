namespace FootnallLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The League class
    /// </summary>    
    public class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Matche> mathes = new List<Matche>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Matche> Mathes
        {
            get { return mathes; }
        }

        
        

        public void AddMatch(Matche matche)
        {
            if (this.IsMatheExist(matche))
            {
                 throw new InvalidOperationException("Match already exists in the league.");
            }

            mathes.Add(matche);
        }

        public void AddTeam(Team team)
        {
            if (this.IsTeamExist(team))
            {
                throw new InvalidOperationException("Team already exists in the league.");
            }

            teams.Add(team);
        }

        static void Main()
        {
        }

        private bool IsMatheExist(Matche matche)
        {
            return mathes.Any(m => m.ID == matche.ID);
        }

        private bool IsTeamExist(Team team)
        {
            return teams.Any(t => t.Name == team.Name);
        }
    }
}
