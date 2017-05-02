namespace Models
{

    public class Categories
    {
        public string id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }

}