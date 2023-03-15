using System.Diagnostics.Eventing.Reader;

namespace Tournament
{
    public partial class FourTeams : Form
    {
        // this is a variable that helps to keep track of if there are currently 4 teams registered or 8
        static int timesMoreTeamsCalled = 0;
        bool isChecked;
        public FourTeams()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FourTeams fourTeamsTwo = new FourTeams();
            fourTeamsTwo.Show();
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
                // if the checkbox is not checked go to the tournament
                if (!isChecked)
                {
                    FourTeamTournament fourTeamTournament = new FourTeamTournament();
                    fourTeamTournament.Show();
                }
                else
                {
                    // 4 teams are registered
                    if (timesMoreTeamsCalled == 0)
                    {
                        FourTeams fourTeamsTwo = new FourTeams();
                        fourTeamsTwo.Show();
                    }
                    // 8 teams registered
                    else
                    {
                        EightTeams eightTeams = new EightTeams();
                        eightTeams.Show();
                    }
                    timesMoreTeamsCalled++;
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
    }
}