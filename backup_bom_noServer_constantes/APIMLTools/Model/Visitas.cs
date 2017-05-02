using System.Collections.Generic;

namespace Models.TotalDeVisitas
{
    #region TotalDeVisitas
    public class VisitsDetail
    {
        public string company { get; set; }
        public int quantity { get; set; }
    }

    public class TotalDeVisitasPorUser
    {
        public int user_id { get; set; }
        public string date_from { get; set; }
        public string date_to { get; set; }
        public int total_visits { get; set; }
        public List<VisitsDetail> visits_detail { get; set; }
    }
    #endregion: 

    #region TotalDeVisitas

    public class TotalDeVisitasPorItem
    {
        public string item_id { get; set; }
        public string date_from { get; set; }
        public string date_to { get; set; }
        public int total_visits { get; set; }
        public List<VisitsDetail> visits_detail { get; set; }
    }
    #endregion: 

    

}
