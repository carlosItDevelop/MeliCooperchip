using System.Collections.Generic;

namespace Models
{
 

    public class newVendedor
    {
        public string site_id { get; set; }
        public Paging paging { get; set; }
        public List<object> results { get; set; }
        public List<object> secondary_results { get; set; }
        public List<object> related_results { get; set; }
        public Sort sort { get; set; }
        public List<AvailableSort> available_sorts { get; set; }
        public List<object> filters { get; set; }
        public List<object> available_filters { get; set; }
    }

}
