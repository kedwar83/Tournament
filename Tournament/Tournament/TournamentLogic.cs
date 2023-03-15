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
        int TeamWins;
        string TeamName;
        public TeamsInTournament(int teamWins, string teamName) {
            TeamWins = teamWins;
            TeamName = teamName;
        }
    }
    internal class TournamentLogic
    {
        static int teamsArrayIterator = 0, teamWins;
        static string? teamName;
        static List <TeamsInTournament> teams = new List<TeamsInTournament>();
        public static bool AreAllTextboxesFilled(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;

                    if (string.IsNullOrEmpty(tb.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void updateTeamsList(Form form) 
        {
            foreach (Panel panel in form.Controls.OfType<Panel>())
            {
                foreach(TextBox textBox in panel.Controls.OfType<TextBox>())
                {
                    if (textBox.Tag != null && textBox.Tag.ToString() == "Name")
                    {
                        teamName = textBox.Text;
                    }
                    else
                    {
                        teamWins = int.Parse(textBox.Text);
                    }
                    // put the team in the list
                    teams[teamsArrayIterator] = new TeamsInTournament(teamWins, teamName);
                    teamsArrayIterator++;
                }   
            }
        }
    }
}
