using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3
{
    public partial class Form1 : Form
    {
        private VTNZ _vtnz;
        //private List<IServiceType> _serviceList;
        private CarInspectionWrap _inspec1, _inspec2, _inspec3, _inspec4;

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayService();
            DisplayVTNZDetails();
            lblMessage.Text = "Select the inspection type";
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            CarInspectionWrap _selectedService = new CarInspectionWrap();
            if (lstInspections.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lstInspections.SelectedIndex == 0) { _selectedService = _inspec1; }
                if(lstInspections.SelectedIndex == 1) { _selectedService = _inspec2; }
                if(lstInspections.SelectedIndex == 2) { _selectedService = _inspec3; }
                if(lstInspections.SelectedIndex == 3) { _selectedService = _inspec4; }
                _vtnz.RequestService(_selectedService);
                lblDetails.Text += _vtnz.ShowServiceDetail();
                lblCount.Text = _vtnz.ServiceNums.ToString();
                lblTotalPrice.Text = _vtnz.TotalPrice.ToString();

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        void DisplayVTNZDetails()
        {
            _vtnz = new VTNZ("VTNZ North Harbour", "3-5 Saturn Place, Albany", "Mon - Fir - 7.30am - 5pm");
            lblHeader.Text = _vtnz.printDetail();
        }

        void DisplayService()
        {
            _inspec1 = new CarInspectionWrap("WoF inspection", 50);
            _inspec2 = new CarInspectionWrap("Modified vehicle check-up", 200);
            _inspec3 = new CarInspectionWrap("Pre-purchase inspection", 150);
            _inspec4 = new CarInspectionWrap("Vehicle registration", 210);
            lstInspections.Items.Insert(0, _inspec1.Type + "    " + Convert.ToString(_inspec1.Price));
            lstInspections.Items.Insert(1, _inspec2.Type + "    " + Convert.ToString(_inspec2.Price));
            lstInspections.Items.Insert(2, _inspec3.Type + "    " + Convert.ToString(_inspec3.Price));
            lstInspections.Items.Insert(3, _inspec4.Type + "    " + Convert.ToString(_inspec4.Price));
        }
    }
}
