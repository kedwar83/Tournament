using System.Diagnostics.Eventing.Reader;

namespace Tournament
{
    public partial class FourTeams : Form
    {
        // this is a variable that helps to keep track of if there are currently 4 teams registered or 8
        private static int timesMoreTeamsCalled = 0;
        bool isChecked;
        public FourTeams()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static int instanceCount
        {
            get { return timesMoreTeamsCalled; }
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
                // if the checkbox is not checked go to the tournament
                if (!isChecked && FourTeams.timesMoreTeamsCalled == 0)
                {
                    FourTeamTournament fourTeamTournament = new FourTeamTournament();
                    fourTeamTournament.Show();
                }
                else if (!isChecked && FourTeams.timesMoreTeamsCalled != 0)
                {
                    TournamentEightTeams tournament = new TournamentEightTeams();
                    tournament.Show();
                }
                else
                {
                    // 4 teams are registered
                    if (FourTeams.timesMoreTeamsCalled == 0)
                    {
                        FourTeams fourTeamsTwo = new FourTeams();
                        fourTeamsTwo.Show();
                        timesMoreTeamsCalled++;
                    }
                    // 8 teams registered
                    else
                    {
                        EightTeams eightTeams = new EightTeams();
                        eightTeams.Show();
                    }

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = checkBox1.Checked;
        }

        private void WinsBox_Enter(object sender, EventArgs e)
        {

        }

        private void TeamBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FourTeams_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            isChecked = checkBox1.Checked;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}