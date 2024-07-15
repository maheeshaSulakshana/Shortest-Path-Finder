using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPathFinder
{
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();
        }

        public frmResults(List<String> path, double distance, String destination)
        {
            
            InitializeComponent();
            lblDistance.Text = "Total Distance: ";
            lblPath.Text = "";
            lblDistance.Text = lblDistance.Text + distance;
            foreach (String city in path)
            {
                if (lblPath.Text == "")
                {
                    lblPath.Text = city;
                }
                else
                {
                    lblPath.Text = lblPath.Text + "--->" + city;
                }
            }
            lblPath.Text = lblPath.Text + "--->" + destination;
        }

        private void frmResults_Load(object sender, EventArgs e)
        {

        }

        private void frmResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome f1= new frmWelcome();
            f1.Show();
        }
    }
}
