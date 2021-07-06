using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tutorial1
{
    public partial class Form1 : Form
    {
        int hours;
        private ParkingType _parkingType;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoCustomer.Checked = false;
            rdoStaff.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(rdoCustomer.Checked)
            {
                lblCustomer.Text = "Customer Parking\nPay $2 for each hour\nMaximum Limt = 24 hours";
            }
            if (rdoStaff.Checked)
            {
                lblStaff.Text = "Staff Parking\nPay $2 for first ten hours\nPay $2 for each hour in excess of 10 hours\nMaximum Limt = 24 hours";
            }
            btnNext.Enabled = false;
            txtHours.Enabled = true;
            btnCalculate.Enabled = true;
            grpBox.Enabled = false;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCustomer.Text = "";
            lblStaff.Text = "";
            txtAmount.Text = "Parking Amount";
            txtHours.Text = "";
            btnNext.Enabled = true;
            txtHours.Enabled = false;
            btnCalculate.Enabled = false;
            grpBox.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {          
            //double dHours = Math.Ceiling(Convert.ToDouble(txtHours.Text));
            //hours = Convert.ToInt32(dHours);
            //if (Convert.ToDouble(txtHours.Text) < 0)
            //{
            //    MessageBox.Show("You have to enter a postive number!",
            //        "Incorrect input");                
            //    return;
            //}
            if (txtHours.Text != "")
            {
                if (!Regex.IsMatch(txtHours.Text, @"^\d{1,5}?[.]*?\d??$"))
                {
                    MessageBox.Show("You have to enter a postive number into the Hours text box!",
                        "Incorrect input");
                    return;
                }

                try
                {
                    if (rdoCustomer.Checked)
                    {
                        _parkingType = new CustomerParking(double.Parse(txtHours.Text));
                    }
                    if (rdoStaff.Checked)
                    {
                        _parkingType = new StaffParking(double.Parse(txtHours.Text));
                    }
                    txtAmount.Text = "$" + _parkingType.ParkingAmount().ToString();
                }
                catch (ParkingException ex)
                {
                    MessageBox.Show(ex.Message, "Exceeding 24 hours");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number into the Hours text box!",
                        "Error message");
            }
                      
            
        }


    }
}
