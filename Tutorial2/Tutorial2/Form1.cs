using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private IKiosk _obj;
        private ParkType _parktype;
        decimal hour;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "PARKING AVAILABLE\nGeneral Public - $2.00 per hour\n" +
                "Staff - $2.00 for first ten hours and $2.00 per hour thereafter\n" +
                "Student - $1.00 per hour";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rdoGeneral.Checked)
            {
                _parktype = ParkType.General;
            }
            if (rdoStaff.Checked)
            {
                _parktype = ParkType.Staff;
            }
            if (rdoStudent.Checked)
            {
                _parktype = ParkType.Student;
            }

            
            if (txtHours.Text != "")
            {
                if (!Regex.IsMatch(txtHours.Text, @"^\d{1,5}?[.]*?\d??$"))
                {
                    MessageBox.Show("You have to enter a postive number into the Hours text box!",
                        "Incorrect input");
                    return;
                }
                hour = Convert.ToDecimal(txtHours.Text);

                if (_parktype == ParkType.General)
                {
                    _obj = new GenKioskWrap(hour);
                }
                else if(_parktype == ParkType.Staff)
                {
                    _obj = new StaffKioskWrap(hour);
                }
                else if(_parktype == ParkType.Student)
                {
                    _obj = new StuKioskWrap(hour);
                }
                txtAmount.Text = "$" + _obj.FindParkingAmount().ToString();
                
            }
            else
            {
                MessageBox.Show("Please enter a number into the Hours text box!",
                    "Error message");
            }
        }
    }
}
