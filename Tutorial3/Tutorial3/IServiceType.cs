using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public interface IServiceType
    {
        decimal Price { get; }
        string Type { get;  }
        string ShowServiceDetail();
    }
}