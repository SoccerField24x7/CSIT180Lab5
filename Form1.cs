using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMileage.Text = "0";
            lblMiles.Text = "0";
            lblTotal.Text = "0";
            this.ActiveControl = txtPrice;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var selVehicle = groupBox1.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            var selRoute = groupBox2.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selVehicle == null || selRoute == null)
            {
                MessageBox.Show("You Must Select a Vehicle and Route Before Calculating.");
                return;
            }

            // decimal mpg = selVehicle.Text == "PT Cruiser" ? 

            //var total = CalculateGallonsUsed();

            //lblTotal.Text = total.ToString();

        }

        /* BL */
        private decimal CalculateGallonsUsed(decimal mpg, decimal distance)
        {

            // i.e. 3 miles, 35 mpg, $3.99/gal

            // need to know how many gallons?

            // 1 gallon = 35 miles traveled.  x = 3 miles.
            // 1 / 35 = x / 3
            // 3 (1 / 35) = x
            // 3/35 = x
            // miles traveled / mpg = gallons used

            return distance / mpg;
        }

        private decimal CalculateCostPerTrip(decimal distanceTraveled, decimal gallonsUsed)
        {
            return distanceTraveled * gallonsUsed;
        }
    }
}
