using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Properties.Model
{
    interface Iseller
    {
        seller GetSeller(string id);
    }
}