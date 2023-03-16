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
    public partial class TournamentThirtyTwoTeams : Form
    {
        public TournamentThirtyTwoTeams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is tournament16 idk why its called tournament eight
            TournamentEight tournament = new TournamentEight();
            tournament.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TournamentThirtyTwoTeams_Load(object sender, EventArgs e)
        {
            TournamentLogic.FillInBracket(this);
        }
    }
}
