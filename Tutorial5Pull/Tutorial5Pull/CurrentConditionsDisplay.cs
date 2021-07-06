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
    public partial class CurrentConditionsDisplay : Form, IObserver, IDisplayElement
    {
        //温度，气压，湿度
        private float _temp;
        private float _humidity;
        private int _pressure;

        private ISubject _subject;
        WeatherData weatherData = new WeatherData();

        public CurrentConditionsDisplay(ISubject subject)
        {
            InitializeComponent();
            this._subject = subject;
        }

        //显示
        public void Display()
        {
            txtTemp.Text = _temp.ToString();
            txtHumidity.Text = _humidity.ToString();
            txtPressure.Text = _pressure.ToString();
        }

        //更新， 天气情况是由weatherdata来调用，使用推送模式
        public void Update(float temp, float humidity, int pressure)
        {
            //throw new NotImplementedException();
            this._temp = temp;
            this._humidity = humidity;
            this._pressure = pressure;
            Display();
        }

        public void UpdatePull()
        {
            //throw new NotImplementedException();
            
            Update(weatherData.Temp, weatherData.Humidity, weatherData.Pressure);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            weatherData.RegisterObserver(this);
            btnRegister.Enabled = false;
        }

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            weatherData.RemoveObserver(this);
            btnRegister.Enabled = true;
        }


    }
}
