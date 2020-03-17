﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string NameandTime = txtCompetitorName.Text + String.Format(" ({0:0.00}s)", CompTime);
            lblCompetitorName.Text = "Competitor" + (counter + 1) + "'s Name:";
            lblCompetitorTime.Text = "Competitor" + (counter + 1) + "'s Time:";
            listResults.Items.Add(NameandTime);

            if (counter == results)
            {
                groupBoxInfo.Enabled = false;
            }

        }
        private object[] SortNumericItems(object[] items)
        {
            // Get the numeric values of the items.
            int results = items.Length;
            const string float_pattern = @"-?\d+\.?\d*";
            double[] values = new double[results];
            for (int i = 0; i < results; i++)
            {
                string match = Regex.Match(
                    items[i].ToString(), float_pattern).Value;
                double value;
                if (!double.TryParse(match, out value))
                    value = double.MinValue;
                values[i] = value;
            }

            // Sort the items array using the keys to determine order.
            Array.Sort(values, items);
            return items;
        }

        private void btnRank_Click(object sender, EventArgs e)
        {

            // Get the original items as an array.
            int results = listResults.Items.Count;
            object[] items = new object[results];
            listResults.Items.CopyTo(items, 0);

            // Sort them by their contained numeric values.
            items = SortNumericItems(items);

            // Display the results.
            listResults.Sorted = false;
            listResults.DataSource = items;
        }
    }
}
