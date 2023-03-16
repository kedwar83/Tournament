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
    public partial class SixteenTeams : Form
    {
        public SixteenTeams()
        {
            InitializeComponent();
        }
        bool isChecked;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void SixteenTeams_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = checkBox1.Checked;
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
                    ThirtyTwoTeams teams = new ThirtyTwoTeams();
                    teams.Show();
                }
                else
                {
                    TournamentThirtyTwoTeams tournament = new TournamentThirtyTwoTeams();
                    tournament.Show();
                }

            }

        }
    }
}

