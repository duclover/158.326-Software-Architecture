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
    public partial class WeatherStatistics : Form, IObserver, IDisplayElement
    {
        //private float _temp;
        private float _maxtemp;
        private float _mintemp;
        private float _sumtemp;
        private float _avgtemp;
        private int _count;
        private ISubject _subject;

        public WeatherStatistics(ISubject subject)
        {
            InitializeComponent();
            this._subject = subject;
        }

        public void Display()
        {
            //throw new NotImplementedException();
            txtAverage.Text = _avgtemp.ToString();
            txtMax.Text = _maxtemp.ToString();
            txtMin.Text = _mintemp.ToString();

        }

        public void Update(float temp, float humidity, int pressure)
        {
            //throw new NotImplementedException();
            //_temp = temp;
            if(_count == 0)
            {
                _maxtemp = _mintemp = temp;
            }
            
            ++_count;
            _sumtemp += temp;
            

            if(temp < _mintemp)
            {
                this._mintemp = temp;
            }
            if(temp > _maxtemp)
            {
                this._maxtemp = temp;
            }
            _avgtemp = _sumtemp / _count;
            Display();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
            btnRegister.Enabled = false;
        }

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
            btnRegister.Enabled = true;
        }
    }
}
