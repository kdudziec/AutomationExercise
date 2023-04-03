using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITesting.DataModels
{
    public class AllBrandsList
    {

        public int responseCode { get; set; }
        public string message { get; set; }    
        public Brand[] brands { get; set; }


        public class Brand
        {
            public int id { get; set; }
            public string brand { get; set; }
        }

    }
}
