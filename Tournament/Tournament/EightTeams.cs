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
        public EightTeams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SixteenTeams sixteenTeams = new SixteenTeams();
            sixteenTeams.Show();
        }
    }
}
