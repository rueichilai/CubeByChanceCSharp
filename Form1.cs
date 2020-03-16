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

        int counter = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblCompetitorName.Text = lblCompetitorName.Text + (counter + 1) + "'s Name:";
            lblCompetitorTime.Text = lblCompetitorTime.Text + (counter + 1) + "'s Time:";
        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoundNext_Click(object sender, EventArgs e)
        {
            
            int results = int.Parse(txtCompetitorsNum.Text);
            //int[] result = new int[results];

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

            counter++;
            string CompTime = txtCompetitorTime.Text;
            string NameandTime = txtCompetitorName.Text + String.Format(" ({0:0.00})", CompTime);
            lblCompetitorName.Text = "Competitor" + (counter + 1) + "'s Name:";
            lblCompetitorTime.Text = "Competitor" + (counter + 1) + "'s Time:";
            listResults.Items.Add(NameandTime);
            
            if (counter == results)
            {
                groupBoxInfo.Enabled = false;
            }
        }
    }
}
