using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament
{
    public partial class TournamentEightTeams : Form
    {
        public TournamentEightTeams()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TournamentLogic.FillInBracket(this);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FourTeamTournament tournament = new FourTeamTournament();
            tournament.Show();
        }
    }
}
