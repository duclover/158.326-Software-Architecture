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
    //包含最新的天气情况，
    //含有观察者集合，使用list
    //当数据有更新时，就主动的调用list，通知所有接入方就看到最新信息
    public partial class WeatherData : Form, ISubject
    {
        private float _temp;
        private float _humidity;
        private int _pressure;

        //观察者集合
        private List<IObserver> _observers = new List<IObserver>();

        //public float Temp { get; set; }
        //public float Humidity { get; set; }
        //public int Pressure { get; set; }

        public WeatherData()
        {
            InitializeComponent();
            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(this);
            ccd.Show();
            ForecastDisplay fd = new ForecastDisplay(this);
            fd.Show();
            WeatherStatistics ws = new WeatherStatistics(this);
            ws.Show();
        }

        public void NotifyObservers()
        {
            //throw new NotImplementedException();
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temp, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            //throw new NotImplementedException();
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            //throw new NotImplementedException();
            _observers.Remove(observer);
        }

        public void MeasurementChanged()
        {
            float.TryParse(txtTemp.Text, out _temp);
            float.TryParse(txtHumidity.Text, out _humidity);
            int.TryParse(txtPressure.Text, out _pressure);

            NotifyObservers();
        }

        private void txtTemp_Leave(object sender, EventArgs e)
        {
            MeasurementChanged();
        }

        private void txtHumidity_Leave(object sender, EventArgs e)
        {
            MeasurementChanged();
        }

        private void txtPressure_Leave(object sender, EventArgs e)
        {
            MeasurementChanged();
        }
    }
}
