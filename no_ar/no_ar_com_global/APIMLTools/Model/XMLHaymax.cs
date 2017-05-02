using System.Collections.Generic;

namespace Models.XML
{

    public class crossDocking
    {
        public string customerId { get; set; }
        public string company { get; set; }
        public string database { get; set; }
        public string numberResults { get; set; }
        public List<Product> products { get; set; }
    }


    public class Product
    {

        public Product()
        {

        }

        public Information information { get; set; }
        public int prod_id { get; set; }
        public string brand { get; set; }
        public string prod_name { get; set; }
        public string seg_name { get; set; }
        public string image { get; set; }
        public string link { get; set; }
        public string NBM { get; set; }
        public string saleUnit { get; set; }
        public string saleQuant { get; set; }
        public string weightValue { get; set; }
        public string weightUnit { get; set; }
        public string shortName { get; set; }
        public string EAN { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string depth { get; set; }
        public string PPB { get; set; }
        public string warrantyDays { get; set; }
        public string price { get; set; }
        public string stock { get; set; }
        public string IPI { get; set; }
        public string sourceFat { get; set; }

        public override string ToString()
        {
            return prod_name;
        }

    }

    public class Information
    {
        public string description { get; set; }
        public string characteristics { get; set; }
        public string thechnical { get; set; }
        public string included { get; set; }
    }

    public class XMLHayamax
    {
        public string XMLVersion { get; set; }
    }

}
