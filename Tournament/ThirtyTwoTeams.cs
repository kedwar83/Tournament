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
    public partial class ThirtyTwoTeams : Form
    {
        public ThirtyTwoTeams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ThirtyTwoTeams_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool allFieldsFilled = TournamentLogic.AreAllTextboxesFilled(this.Controls);

            if (!allFieldsFilled)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                TournamentLogic.UpdateTeamsList(this);
                TournamentSixtyFourTeams tournament = new TournamentSixtyFourTeams();
                tournament.Show();
            }
        }
    }
}