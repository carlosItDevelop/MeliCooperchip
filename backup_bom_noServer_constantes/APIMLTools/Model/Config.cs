
namespace Models
{
    public static class Config
    {


        // Teste (offline)
        private static long appid = 3686926935085794;
        private static string secretid = "hrw1H7pJsYGWbnGIVkXlvqXJuer0P4VY";

        //// Produ (online)
        //private static long appid = ;
        //private static string secretid = "";

        public static long Appid
        {
            get { return appid; }
        }

        public static string Secretid
        {
            get { return secretid; }
        }
    }
}
