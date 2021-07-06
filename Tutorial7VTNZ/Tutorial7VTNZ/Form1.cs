using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial7VTNZ
{
    public partial class Form1 : Form
    {
        private VTNZ _vtnz;
        private List<IServiceType> _serviceList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            DisplayService();
            DisplayVTNZDetails();
            lblMessage.Text = "Select the inspection type";
        }

        private void DisplayVTNZDetails()
        {
            _vtnz = VTNZ.GetInstance("VTNZ North Harbour", "3-5 Saturn Place, Albany", "Mon-Fri 7:30am-5pm");
            lblHeader.Text = _vtnz.PrintDetail();
        }

        private void DisplayService()
        {
            _serviceList = new List<IServiceType> {
                new CarInspectionWrap("WoF inspection", 50M),
                new CarInspectionWrap("Modified vehicle check-up", 200M),
                new CarInspectionWrap("Pre-purchase inspection",150M),
                new CarInspectionWrap("Certificate of Fitness",210M) };
            int numberOfItem = _serviceList.Count;
            for (int i = 0; i < numberOfItem; ++i)
            {
                lstInspections.Items.Insert(i, _serviceList[i].Type + " " + _serviceList[i].Price);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstInspections.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a service type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IServiceType selectedService = new CarInspectionWrap();
                switch (selectedIndex)
                {
                    case 0:
                        selectedService = _serviceList[0];
                        break;
                    case 1:
                        selectedService = _serviceList[1];
                        break;
                    case 2:
                        selectedService = _serviceList[2];
                        break;
                    case 3:
                        selectedService = _serviceList[3];
                        break;
                }
                _vtnz.RequestService(selectedService);
                lblDetails.Text += "Inspection Type: " + _vtnz.ShowServiceDetail();
                lblCount.Text = VTNZ.ServiceNums.ToString();
                lblTotalPrice.Text = VTNZ.TotalPrice.ToString();
            }
        }

    }
}
