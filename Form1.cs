using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeByChance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoundNext_Click(object sender, EventArgs e)
        {
            string RoundNum = txtRoundNumber.Text;
            comboboxRound.Items.Add(RoundNum);

            if (txtCompetitorsNum.Text == "")
            {
                MessageBox.Show("Please enter the Amount of Competitors");
                txtCompetitorsNum.Select();
                return;
            }
            
            if (txtCompetitorName.Text == "")
            {
                MessageBox.Show("Please enter Competitor's Name");
                txtCompetitorName.Select();
                return;
            }

            if (txtCompetitorTime.Text == "")
            {
                MessageBox.Show("Please enter Competitor's Time");
                txtCompetitorTime.Select();
                return;

            }

            if (txtRoundNumber.Text == "")
            {
                MessageBox.Show("Please Enter the Round Number");
                txtRoundNumber.Select();
                return;
            }
        }

        
    }
}
