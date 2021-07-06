using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial6
{
    public partial class Form1 : Form
    {
        private EDuck _duckType;
        private Duck _duck;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckDuckType()
        {
            if (rdoMallard.Checked)
            {
                _duckType = EDuck.MallardDuck;
            }
            if (rdoRedHead.Checked)
            {
                _duckType = EDuck.RedHeadDuck;
            }
            if (rdoDecoyDuck.Checked)
            {
                _duckType = EDuck.DecoyDuck;
            }
            if (rdoRubberDuck.Checked)
            {
                _duckType = EDuck.RubberDuck;
            }

            switch (_duckType)
            {
                case EDuck.MallardDuck:
                    _duck = new MallardDuck();
                    break;
                case EDuck.DecoyDuck:
                    _duck = new DecoyDuck();
                    break;
                case EDuck.RubberDuck:
                    _duck = new RubberDuck();
                    break;
                case EDuck.RedHeadDuck:
                    _duck = new RedHeadDuck();
                    break;

            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblDisplay.Text = _duck.Display();
        }

        private void btnFly_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblDisplay.Text = _duck.PerformFly();
        }

        private void btnQuack_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblDisplay.Text = _duck.PerformQuack();
        }
    }
}
