using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial5
{
    //观察者接口，由观察者来实现
    public interface IObserver
    {
        void Update(float temp, float humidity, int pressure);

        //void UpdatePull();
    }
}
