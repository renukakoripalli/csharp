using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Model
{
    public class Sellerr : Sinterface
    {
        private List<Seller> sel;
        public Sellerr()
        {
            sel = new List<Seller>
            { new Seller(1, 12, "dev", "dev@530", "ssss", "gfwagy", "qatwr", "twrtyer", "rwtyret", "dsge"),
               new Seller(11, 1211, "devi", "dev@5300", "ssss", "gfwagy", "qatwr", "twrtyer", "rwtyret", "dsge"),
               new Seller(111, 121, "devika", "dev@5300", "ssss", "gfwagy", "qatwr", "twrtyer", "rwtyret", "dsge")
            };
        }
        public Seller Get(int id)
        {
            Seller me = sel.FirstOrDefault(e => e.Id == id);
            return me;
        }

        ////    se = new List<Seller>() { new Seller(1, "sdf", "dsfgd","dsfg","dsf","sdg","dsfg","dsf","dfg",3),
        ////                new Seller(2, "sdf", "dsfgd","dsfg","dsf","sdg","dsfg","dsf","dfg",4),
        ////                new Seller(3, "sdf", "dsfgd","dsfg","dsf","sdg","dsfg","dsf","dfg",5),

        ////    };
        ////}
        ////public Seller Get(int id)
        ////{
        ////    Seller s = se.FirstOrDefault(s => s.Id == id);
        ////    return s;
        ////}
        public List<Seller> DisplayDetails()
        {
            return sel;
        }
    }
}