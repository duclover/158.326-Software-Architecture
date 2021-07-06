using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7VTNZ
{
    public interface IServiceType
    {
        decimal Price { get; }
        string Type { get; }
        string ShowServiceDetail();
    }
}