using System.Collections.Generic;

namespace Models.Pergunta
{

    public class Answer
    {
        public string date_created { get; set; }
        public string status { get; set; }
        public string text { get; set; }
    }

    public class From
    {
        public int id { get; set; }
        public int answered_questions { get; set; }
    }

    public class Question
    {
        public object id { get; set; }
        public Answer answer { get; set; }
        public string date_created { get; set; }
        public string item_id { get; set; }
        public int seller_id { get; set; }
        public string status { get; set; }
        public string text { get; set; }
        public From from { get; set; }
    }

    public class Pergunta
    {
        public int total { get; set; }
        public int limit { get; set; }
        public List<Question> questions { get; set; }
    }


}