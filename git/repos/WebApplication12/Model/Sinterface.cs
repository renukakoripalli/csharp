using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Model
{
    public interface Sinterface
    {
        Seller Get(int id);
        List<Seller> DisplayDetails();
    }
}