using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    public class TeamsInTournament
    {
        private int teamWins;
        private string teamName;
        public TeamsInTournament(int teamWins, string teamName)
        {
            this.teamWins = teamWins;
            this.teamName = teamName;
        }
        public int TeamWins
        {
            get { return this.teamWins; }

        }
        public String TeamName
        {
            get { return this.teamName; }
        }
    }

    internal class TournamentLogic
    {
        static int panelCount = 0, teamsArrayIterator = 0, i = 0;

        static List<TeamsInTournament> teams = new List<TeamsInTournament>(64);
        public static bool AreAllTextboxesFilled(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;

                    if (string.IsNullOrWhiteSpace(tb.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void UpdateTeamsList(Form form)
        {
            int teamWins = -1;
            string teamName = "";

            foreach (Panel panel in form.Controls.OfType<Panel>())
            {
                foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
                {
                    if (textBox.Tag != null && textBox.Tag.Equals("Name"))
                    {
                        teamName = textBox.Text;
                    }
                    else 
                    {
                        teamWins = int.Parse(textBox.Text);
                    }
                }
                // put the team in the list
                teams.Add(new TeamsInTournament(teamWins, teamName));
            }
        }
    
        public static int DecideWinner(Form form, int wins1, int wins2)
        {
            Random random = new Random();
            //chosing a random winner based off the winrates
            // the odds of the team with the greater winrate winning are 
            // winnerWinrate/ (winnerWinrate+loserWinrate)
            //ex: 30/(30+10) = .75 
            int randomNumber = random.Next(0, wins1 + wins2);
            if (randomNumber > wins1)
            {
                // index of wins1
                return (teams.Count - 1 - i);
            }
            else
            { 
                // index of wins2
                return i;
            }
        }

        public static void FillInBracket(Form form)
        {
            i = 0;
            // sort teams
            teams.Sort((t1, t2) => t1.TeamWins.CompareTo(t2.TeamWins));
            TeamsInTournament[] winnerTeams = new TeamsInTournament[teams.Count / 2];
            while (i < teams.Count/2)
            {
                foreach (Panel panel in form.Controls.OfType<Panel>())
                {
                    foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
                    {
                        if (panelCount == 0)
                        {
                            textBox.Text = teams[i].TeamName;
                            panelCount++;
                        }
                        else
                        {
                            //matching the next best team with the next worst team
                            textBox.Text = teams[(teams.Count - 1) - i].TeamName;
                            panelCount = 0;
                        }
                    }
                    // we put the winning team into a new array of just winning teams
                    winnerTeams[i] = teams[DecideWinner(form, teams[(teams.Count - 1) - i].TeamWins, teams[i].TeamWins)];
                    i++;
                }
            }
            //clear teams and add the winner teams for the next bracket
            teams.Clear();
            teams.AddRange(winnerTeams);
        }
    }
}


