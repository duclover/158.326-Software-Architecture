using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5
{
    public partial class ForecastDisplay : Form, IObserver, IDisplayElement
    {
        private int _pressure;
        private ISubject _subject;
        WeatherData weatherData = new WeatherData();

        public ForecastDisplay(ISubject subject)
        {
            InitializeComponent();
            this._subject = subject;
        }

        public void Display()
        {
            //throw new NotImplementedException();
            if (_pressure < 1000)
            {
                txtConditon.Text = "Rain";
            }
            else
            {
                txtConditon.Text = "Sunshine";
            }
        }

        public void Update(float temp, float humidity, int pressure)
        {
            //throw new NotImplementedException();
            this._pressure = pressure;
            Display();
        }

        public void UpdatePull()
        {
            Update(0, 0, weatherData.Pressure);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            weatherData.RegisterObserver(this);
            btnRegister.Enabled = false;
        }

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            weatherData.RegisterObserver(this);
            btnRegister.Enabled = true;
        }
    }
}
