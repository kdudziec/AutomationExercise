﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITesting.DataModels
{
    public class SearchedProducts
    {


        public int responseCode { get; set; }
        public string message{ get; set; }
        public Product[] products { get; set; }
        

        public class Product
        {
            public int id { get; set; }
            public string name { get; set; }
            public string price { get; set; }
            public string brand { get; set; }
            public Category category { get; set; }
        }

        public class Category
        {
            public Usertype usertype { get; set; }
            public string category { get; set; }
        }

        public class Usertype
        {
            public string usertype { get; set; }
        }


    }
}
