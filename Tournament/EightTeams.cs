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
    public partial class EightTeams : Form
    {
        bool isChecked;
        public EightTeams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool allFieldsFilled = TournamentLogic.AreAllTextboxesFilled(this.Controls);

            if (!allFieldsFilled)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                TournamentLogic.UpdateTeamsList(this);
                if (isChecked)
                {
                    SixteenTeams sixteenTeams = new SixteenTeams();
                    sixteenTeams.Show();
                }
                else
                {
                    TournamentEight tournament = new TournamentEight();
                    tournament.Show();
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = checkBox1.Checked;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
